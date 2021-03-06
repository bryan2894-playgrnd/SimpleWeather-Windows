﻿using SimpleWeather.Controls;
using SimpleWeather.Location;
using SimpleWeather.Utils;
using SimpleWeather.UWP.BackgroundTasks;
using SimpleWeather.UWP.Controls;
using SimpleWeather.UWP.Helpers;
using SimpleWeather.UWP.Tiles;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace SimpleWeather.UWP.Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocationsPage : CustomPage, IDisposable, IWeatherErrorListener
    {
        private WeatherManager wm;

        private Geolocator geolocal;
        private LocationPanelAdapter PanelAdapter;

        public bool EditMode { get; set; } = false;
        private bool DataChanged = false;
        private bool HomeChanged = false;
        private bool[] ErrorCounter;
        private CancellationTokenSource cts;

        private muxc.NavigationViewItem EditButton;

        public void Dispose()
        {
            cts?.Dispose();
        }

        private void OnWeatherLoaded(LocationData location, Weather weather)
        {
            var dataSet = PanelAdapter.GetDataset();

            if (cts?.IsCancellationRequested == true)
                return;

            if (weather?.IsValid() == true)
            {
                // Update panel weather
                LocationPanelViewModel panelView = null;

                if (location?.locationType == LocationType.GPS)
                {
                    panelView = dataSet.FirstOrDefault(panelVM => panelVM?.LocationData?.locationType == LocationType.GPS);
                }
                else
                {
                    panelView = dataSet.FirstOrDefault(panelVM =>
                        (bool)!panelVM.LocationData?.locationType.Equals(LocationType.GPS)
                            && (bool)panelVM.LocationData?.query?.Equals(location?.query));
                }

                // Just in case
                if (panelView == null)
                {
                    AnalyticsLogger.LogEvent("LocationsPage: panelView == null");
                    panelView = dataSet.FirstOrDefault(panelVM => panelVM.LocationData.name.Equals(location?.name) &&
                                                    panelVM.LocationData.latitude.Equals(location?.latitude) &&
                                                    panelVM.LocationData.longitude.Equals(location?.longitude) &&
                                                    panelVM.LocationData.tz_long.Equals(location?.tz_long));
                }

                if (panelView != null)
                {
                    panelView.SetWeather(weather);
                    Task.Run(panelView.UpdateBackground);
                }
            }
        }

        public void OnWeatherError(WeatherException wEx)
        {
            if (cts?.IsCancellationRequested == true)
                return;

            Dispatcher.LaunchOnUIThread(() =>
            {
                switch (wEx.ErrorStatus)
                {
                    case WeatherUtils.ErrorStatus.NetworkError:
                    case WeatherUtils.ErrorStatus.NoWeather:
                        // Show error message and prompt to refresh
                        // Only warn once
                        if (!ErrorCounter[(int)wEx.ErrorStatus])
                        {
                            Snackbar snackbar = Snackbar.Make(wEx.Message, SnackbarDuration.Short);
                            snackbar.SetAction(App.ResLoader.GetString("action_retry"), () =>
                            {
                                // Reset counter to allow retry
                                ErrorCounter[(int)wEx.ErrorStatus] = false;
                                RefreshLocations();
                            });
                            ShowSnackbar(snackbar);
                            ErrorCounter[(int)wEx.ErrorStatus] = true;
                        }
                        break;

                    case WeatherUtils.ErrorStatus.QueryNotFound:
                    default:
                        // Show error message
                        // Only warn once
                        if (!ErrorCounter[(int)wEx.ErrorStatus])
                        {
                            ShowSnackbar(Snackbar.Make(wEx.Message, SnackbarDuration.Short));
                            ErrorCounter[(int)wEx.ErrorStatus] = true;
                        }
                        break;
                }
            });
        }

        public LocationsPage()
        {
            this.InitializeComponent();

            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
                NavigationCacheMode = NavigationCacheMode.Disabled;
            else
                NavigationCacheMode = NavigationCacheMode.Required;

            Application.Current.Resuming += LocationsPage_Resuming;

            wm = WeatherManager.GetInstance();

            geolocal = new Geolocator() { DesiredAccuracyInMeters = 5000, ReportInterval = 900000, MovementThreshold = 1600 };

            PanelAdapter = new LocationPanelAdapter(LocationsPanel);
            PanelAdapter.ListChanged += LocationPanels_CollectionChanged;

            Binding srcBinding = new Binding()
            {
                Mode = BindingMode.OneWay,
                Source = PanelAdapter.ViewSource
            };
            LocationsPanel.SetBinding(ItemsControl.ItemsSourceProperty, srcBinding);

            ErrorCounter = new bool[Enum.GetValues(typeof(WeatherUtils.ErrorStatus)).Length];

            // CommandBar
            CommandBarLabel = App.ResLoader.GetString("Nav_Locations/Content");
            PrimaryCommands = new List<muxc.NavigationViewItemBase>()
            {
                new muxc.NavigationViewItem()
                {
                    Icon = new SymbolIcon(Symbol.Edit),
                    Content = App.ResLoader.GetString("action_editmode"),
                }
            };
            EditButton = PrimaryCommands[0] as muxc.NavigationViewItem;
            EditButton.Tapped += AppBarButton_Click;
            cts = new CancellationTokenSource();

            AnalyticsLogger.LogEvent("LocationsPage");
        }

        private void LocationsPage_Resuming(object sender, object e)
        {
            AnalyticsLogger.LogEvent("LocationsPage: LocationsPage_Resuming");
            RefreshLocations();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            AnalyticsLogger.LogEvent("LocationsPage: OnNavigatedTo");

            cts = new CancellationTokenSource();

            if (e.NavigationMode == NavigationMode.Back || e.NavigationMode == NavigationMode.New)
            {
                // Remove all from backstack except home
                if (this.Frame.BackStackDepth >= 1)
                {
                    try
                    {
                        var home = this.Frame.BackStack.ElementAt(0);
                        this.Frame.BackStack.Clear();
                        this.Frame.BackStack.Add(home);
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLine(LoggerLevel.Error, ex, "Exception!!");
                    }
                }
            }

            if (e.Parameter != null)
            {
                string arg = e.Parameter.ToString();

                switch (arg)
                {
                    case "toast-refresh":
                        RefreshLocations();
                        return;

                    default:
                        break;
                }
            }

            if (PanelAdapter?.ItemCount == 0)
            {
                // New instance; Get locations and load up weather data
                LoadLocations();
            }
            else
            {
                // Refresh view
                RefreshLocations();
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);

            // Cancel edit mode if moving away
            if (EditMode)
                ToggleEditMode();

            // Reset error counter
            Array.Clear(ErrorCounter, 0, ErrorCounter.Length);

            cts?.Cancel();
        }

        private void StackControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Resize StackControl items
            double StackWidth = LocationsPanel.ActualWidth;
            LocationsPanel.Height = this.ActualHeight;

            if (StackWidth <= 0)
                return;

            if (LocationsPanel.ItemsPanelRoot is ItemsWrapGrid WrapsGrid)
            {
                if (StackWidth >= 1280)
                {
                    WrapsGrid.ItemWidth = (StackWidth - WrapsGrid.Margin.Left - WrapsGrid.Margin.Right) / 4;
                }
                else if (StackWidth >= 1007)
                {
                    WrapsGrid.ItemWidth = (StackWidth - WrapsGrid.Margin.Left - WrapsGrid.Margin.Right) / 3;
                }
                else if (StackWidth >= 640)
                {
                    WrapsGrid.ItemWidth = (StackWidth - WrapsGrid.Margin.Left - WrapsGrid.Margin.Right) / 2;
                }
                else
                {
                    WrapsGrid.ItemWidth = Double.NaN;
                }
            }
        }

        private void LocationPanels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            bool dataMoved = (e.Action == NotifyCollectionChangedAction.Remove) || (e.Action == NotifyCollectionChangedAction.Move);
            bool onlyHomeIsLeft = PanelAdapter.FavoritesCount == 1;
            bool limitReached = PanelAdapter.ItemCount >= Settings.MAX_LOCATIONS;

            // Flag that data has changed
            if (EditMode && dataMoved)
                DataChanged = true;

            if (EditMode && e.NewStartingIndex == App.HomeIdx)
                HomeChanged = true;

            // Cancel edit Mode
            if (EditMode && onlyHomeIsLeft)
                ToggleEditMode();

            // Disable EditMode if only single location
            EditButton.Visibility = onlyHomeIsLeft ? Visibility.Collapsed : Visibility.Visible;
            AddLocationsButton.Visibility = limitReached ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <summary>
        /// LoadLocations
        /// </summary>
        /// <exception cref="ObjectDisposedException">Ignore.</exception>
        /// <exception cref="InvalidOperationException">Ignore.</exception>
        /// <exception cref="WeatherException">Ignore.</exception>
        private void LoadLocations()
        {
            Task.Run(async () =>
            {
                // Lets load it up...
                var locations = new List<LocationData>(await Settings.GetFavorites());

                await Dispatcher.RunOnUIThread(() =>
                {
                    // Disable EditMode button
                    EditButton.IsEnabled = false;
                    AddLocationsButton.IsEnabled = false;
                    PanelAdapter.RemoveAll();
                });

                cts?.Token.ThrowIfCancellationRequested();

                // Setup saved favorite locations
                LocationData gpsData = null;
                if (Settings.FollowGPS)
                {
                    gpsData = await GetGPSPanel();

                    if (gpsData != null)
                        locations.Insert(0, gpsData);
                }

                foreach (LocationData location in locations)
                {
                    await Dispatcher.RunOnUIThread(() =>
                    {
                        var panel = new LocationPanelViewModel()
                        {
                            // Save index to tag (to easily retreive)
                            LocationData = location
                        };

                        PanelAdapter.Add(panel);
                    });

                    _ = Task.Run(() => new WeatherDataLoader(location)
                                .LoadWeatherData(new WeatherRequest.Builder()
                                    .ForceRefresh(false)
                                    .SetErrorListener(this)
                                    .Build())
                                .ContinueWith((t) =>
                                {
                                    if (t.IsCompletedSuccessfully)
                                    {
                                        OnWeatherLoaded(location, t.Result);
                                    }
                                }));
                }

                await Dispatcher.RunOnUIThread(() =>
                {
                    // Enable EditMode button
                    EditButton.IsEnabled = true;
                    AddLocationsButton.IsEnabled = true;
                });
            });
        }

        private Task<LocationData> GetGPSPanel()
        {
            return Task.Run(async () =>
            {
                if (Settings.FollowGPS)
                {
                    var locData = await Settings.GetLastGPSLocData();

                    if (cts?.IsCancellationRequested == true)
                        return null;

                    if (locData?.query == null)
                    {
                        locData = await UpdateLocation();
                        if (locData != null)
                        {
                            Settings.SaveLastGPSLocData(locData);
                            SimpleLibrary.GetInstance().RequestAction(CommonActions.ACTION_WEATHER_SENDLOCATIONUPDATE);
                        }
                    }

                    if (cts?.IsCancellationRequested == true)
                        return null;

                    if (locData?.query != null)
                    {
                        return locData;
                    }
                }

                return null;
            });
        }

        /// <summary>
        /// RefreshLocations
        /// </summary>
        /// <exception cref="ObjectDisposedException">Ignore.</exception>
        /// <exception cref="InvalidOperationException">Ignore.</exception>
        /// <exception cref="WeatherException">Ignore.</exception>
        private void RefreshLocations()
        {
            Task.Run(async () =>
            {
                await Dispatcher.RunOnUIThread(() =>
                {
                    // Disable EditMode button
                    EditButton.IsEnabled = false;
                    AddLocationsButton.IsEnabled = false;
                });

                // Reload all panels if needed
                var locations = (await Settings.GetLocationData()).ToList();
                if (Settings.FollowGPS)
                {
                    var homeData = await Settings.GetLastGPSLocData();
                    locations.Insert(0, homeData);
                }
                var gpsPanelViewModel = PanelAdapter.GetGPSPanel();

                bool reload = locations.Count != PanelAdapter.ItemCount ||
                    Settings.FollowGPS && gpsPanelViewModel == null || !Settings.FollowGPS && gpsPanelViewModel != null;

                // Reload if weather source differs
                if ((gpsPanelViewModel != null && !Settings.API.Equals(gpsPanelViewModel?.WeatherSource)) ||
                    (PanelAdapter.FavoritesCount > 0 && !Settings.API.Equals(PanelAdapter.GetFirstFavPanel()?.WeatherSource)))
                {
                    reload = true;
                }

                // Reload if panel queries dont match
                if (Settings.FollowGPS)
                {
                    if (!reload && (gpsPanelViewModel != null && !Equals(locations[0]?.query, gpsPanelViewModel?.LocationData?.query)))
                        reload = true;
                }

                cts?.Token.ThrowIfCancellationRequested();

                if (reload)
                {
                    await Dispatcher.RunOnUIThread(() =>
                    {
                        PanelAdapter.RemoveAll();
                        LoadLocations();
                    });
                }
                else
                {
                    var dataset = PanelAdapter.GetDataset();

                    foreach (var view in dataset)
                    {
                        _ = Task.Run(() => new WeatherDataLoader(view.LocationData)
                            .LoadWeatherData(new WeatherRequest.Builder()
                                    .ForceRefresh(false)
                                    .SetErrorListener(this)
                                    .Build())
                                    .ContinueWith((t) =>
                                    {
                                        if (t.IsCompletedSuccessfully)
                                        {
                                            OnWeatherLoaded(view.LocationData, t.Result);
                                        }
                                    }));
                    }

                    await Dispatcher.RunOnUIThread(() =>
                    {
                        // Enable EditMode button
                        EditButton.IsEnabled = true;
                        AddLocationsButton.IsEnabled = true;
                    });
                }
            });
        }

        private void RemoveGPSPanel()
        {
            if (PanelAdapter?.HasGPSPanel == true)
            {
                PanelAdapter.RemoveGPSPanel();
            }
        }

        /// <summary>
        /// UpdateLocation
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WeatherException">Ignore.</exception>
        private async Task<LocationData> UpdateLocation()
        {
            LocationData locationData = null;

            if (Settings.FollowGPS)
            {
                Geoposition newGeoPos = null;
                var geoStatus = GeolocationAccessStatus.Unspecified;

                try
                {
                    geoStatus = await Geolocator.RequestAccessAsync();
                }
                catch (Exception)
                {
                    // Access denied
                }

                try
                {
                    // Fallback to coarse (less accurate) location
                    geolocal.AllowFallbackToConsentlessPositions();
                    newGeoPos = await geolocal.GetGeopositionAsync(TimeSpan.FromMinutes(15), TimeSpan.FromSeconds(10));
                }
                catch (Exception ex)
                {
                    Logger.WriteLine(LoggerLevel.Error, ex, "Error retrieving location");
                }

                if (cts?.IsCancellationRequested == true)
                    return null;

                // Access to location granted
                if (newGeoPos != null)
                {
                    var view = await Task.Run(async () =>
                    {
                        LocationQueryViewModel locView = null;

                        if (cts?.IsCancellationRequested == true)
                            return null;

                        try
                        {
                            locView = await wm.GetLocation(newGeoPos);

                            if (cts?.IsCancellationRequested == true)
                                return null;

                            if (String.IsNullOrWhiteSpace(locView?.LocationQuery))
                                return null;

                            if (String.IsNullOrWhiteSpace(locView.LocationTZLong) && locView.LocationLat != 0 && locView.LocationLong != 0)
                            {
                                String tzId = await TZDB.TZDBCache.GetTimeZone(locView.LocationLat, locView.LocationLong);
                                if (!String.IsNullOrWhiteSpace(tzId))
                                    locView.LocationTZLong = tzId;
                            }
                        }
                        catch (WeatherException)
                        {
                            locView = null;
                        }

                        return locView;
                    });

                    if (String.IsNullOrWhiteSpace(view?.LocationQuery))
                    {
                        // Stop since there is no valid query
                        await Dispatcher.RunOnUIThread(() =>
                        {
                            RemoveGPSPanel();
                        });
                        return null;
                    }

                    // Save location as last known
                    locationData = new LocationData(view, newGeoPos);
                }
            }

            return locationData;
        }

        private async void LocationsPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnalyticsLogger.LogEvent("LocationsPage: LocationsPanel_ItemClick");
            if (e.ClickedItem is LocationPanelViewModel panel)
            {
                try
                {
                    this.Frame.Navigate(typeof(WeatherNow), new WeatherNowArgs()
                    {
                        IsHome = Equals(panel.LocationData, await Settings.GetHomeData()),
                        Location = panel.LocationData
                    });
                    // Remove all from backstack except home
                    this.Frame.BackStack.Clear();
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                }
                catch (Exception ex)
                {
                    Logger.WriteLine(LoggerLevel.Error, ex, "Exception!!");
                }
            }
        }

        private void AddLocationsButton_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsLogger.LogEvent("LocationsPage: AddLocationsButton_Click");
            Frame.Navigate(typeof(LocationSearchPage));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleEditMode();
        }

        private void ToggleEditMode()
        {
            // Toggle EditMode
            EditMode = !EditMode;

            EditButton.Icon = new SymbolIcon(EditMode ? Symbol.Accept : Symbol.Edit);
            EditButton.Content = EditMode ? App.ResLoader.GetString("Label_Done") : App.ResLoader.GetString("action_editmode");
            LocationsPanel.IsItemClickEnabled = !EditMode;
            // Enable selection mode for non-Mobile (non-Touch devices)
            if (!ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                LocationsPanel.IsMultiSelectCheckBoxEnabled = EditMode;
                LocationsPanel.SelectionMode = EditMode ? ListViewSelectionMode.Multiple : ListViewSelectionMode.None;
                if (EditMode && PrimaryCommands.Count == 1)
                {
                    PrimaryCommands.Insert(0,
                        new muxc.NavigationViewItem()
                        {
                            Icon = new SymbolIcon(Symbol.Delete),
                            Content = App.ResLoader.GetString("delete"),
                        }
                    );
                    var deleteBtn = PrimaryCommands[0] as muxc.NavigationViewItem;
                    deleteBtn.Tapped += DeleteBtn_Click;
                }
                else if (PrimaryCommands.Count > 1)
                {
                    PrimaryCommands.Remove(PrimaryCommands[0]);
                }
                Shell.Instance.RequestCommandBarUpdate();
            }

            foreach (LocationPanelViewModel view in PanelAdapter.GetDataset())
            {
                view.EditMode = EditMode;

                var itemContainer = LocationsPanel.ContainerFromItem(view);
                if (itemContainer is SelectorItem container)
                {
                    var presenter = VisualTreeHelperExtensions.FindChild<ListViewItemPresenter>(container);

                    if (presenter != null)
                    {
                        presenter.DisabledOpacity = 1;
                        if (EditMode && view.LocationType == (int)LocationType.GPS)
                        {
                            presenter.CheckBoxBrush = null;
                        }
                        else if (presenter.CheckBoxBrush == null &&
                            App.Current.Resources.TryGetValue("GridViewItemCheckBoxBrush", out object brush))
                        {
                            presenter.CheckBoxBrush = brush as Brush;
                        }
                    }

                    container.IsEnabled = view.LocationType != (int)LocationType.GPS || !EditMode;
                    container.IsHitTestVisible = view.LocationType != (int)LocationType.GPS || !EditMode;
                }
            }

            if (!EditMode && HomeChanged)
            {
                SimpleLibrary.GetInstance().RequestAction(CommonActions.ACTION_WEATHER_SENDLOCATIONUPDATE,
                    new Dictionary<string, object>
                    {
                        { CommonActions.EXTRA_FORCEUPDATE, false }
                    });
            }

            DataChanged = false;
            HomeChanged = false;
        }

        private async void SwipeItem_Invoked(Microsoft.UI.Xaml.Controls.SwipeItem sender, Microsoft.UI.Xaml.Controls.SwipeItemInvokedEventArgs args)
        {
            if (args.SwipeControl is FrameworkElement button && button.DataContext is LocationPanelViewModel view)
            {
                AnalyticsLogger.LogEvent("LocationsPage: SwipeItem_Invoked");
                await PanelAdapter.RemovePanel(view).ConfigureAwait(true);
            }
        }

        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsLogger.LogEvent("LocationsPage: DeleteBtn_Click");
            await PanelAdapter.BatchRemovePanels(LocationsPanel.SelectedItems.Cast<LocationPanelViewModel>()).ConfigureAwait(true);
        }

        private void LocationPanel_Holding(object sender, HoldingRoutedEventArgs e)
        {
            if (e.HoldingState == HoldingState.Started)
            {
                if (!EditMode) ToggleEditMode();
                e.Handled = true;
            }
        }

        private void LocationsPanel_ContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {
            if (args.Item is LocationPanelViewModel view)
            {
                var container = args.ItemContainer;
                var presenter = VisualTreeHelperExtensions.FindChild<ListViewItemPresenter>(container);

                if (presenter != null)
                {
                    presenter.DisabledOpacity = 1;
                    if (EditMode && view.LocationType == (int)LocationType.GPS)
                    {
                        presenter.CheckBoxBrush = null;
                    }
                    else if (presenter.CheckBoxBrush == null &&
                        App.Current.Resources.TryGetValue("GridViewItemCheckBoxBrush", out object brush))
                    {
                        presenter.CheckBoxBrush = brush as Brush;
                    }
                }

                if (container != null)
                {
                    container.IsEnabled = view.LocationType != (int)LocationType.GPS || !EditMode;
                    container.IsHitTestVisible = view.LocationType != (int)LocationType.GPS || !EditMode;
                }
            }
        }
    }
}