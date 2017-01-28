﻿using SimpleWeather.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocationsPage : Page
    {
        WeatherYahoo.WeatherDataLoader wLoader = null;
        WeatherUnderground.WeatherDataLoader wu_Loader = null;
        /* Panel Animation Workaround */
        public List<LocationPanelView> HomePanel { get; set; }
        public ObservableCollection<LocationPanelView> LocationPanels { get; set; }

        public ObservableCollection<LocationQueryView> LocationQuerys { get; set; }
        private string selected_query = string.Empty;

        // For UI Thread
        CoreDispatcher dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;

        public LocationsPage()
        {
            this.InitializeComponent();

            /* Panel Animation Workaround */
            HomePanel = new List<LocationPanelView>(1);
            LocationPanels = new ObservableCollection<LocationPanelView>();
            LocationPanels.CollectionChanged += LocationPanels_CollectionChanged;

            LocationQuerys = new ObservableCollection<LocationQueryView>();

            // Get locations and load up weather data
            LoadLocations();
        }

        private void LocationPanels_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach(LocationPanelView panelView in LocationPanels)
            {
                int index = LocationPanels.IndexOf(panelView) + 1;
                panelView.Pair = new KeyValuePair<int, object>(index, panelView.Pair.Value);
            }

            // Refresh ItemsSource
            OtherLocationsPanel.ItemsSource = null;
            OtherLocationsPanel.ItemsSource = LocationPanels;
        }

        private async void LoadLocations()
        {
            // Lets load it up...
            //List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
            List<string> locations = await Settings.getLocations_WU();
            HomeLocation.ItemsSource = HomePanel;
            OtherLocationsPanel.ItemsSource = LocationPanels;

            //foreach(WeatherYahoo.Coordinate location in locations)
            foreach (string location in locations)
            {
                int index = locations.IndexOf(location);

                LocationPanelView panel = new LocationPanelView();
                panel.Background = new SolidColorBrush(App.AppColor);

                if (index == 0) // Home
                    HomePanel.Add(panel);
                else
                    LocationPanels.Add(panel);
            }

            //foreach (WeatherYahoo.Coordinate location in locations)
            foreach (string location in locations)
            {
                int index = locations.IndexOf(location);

                //wLoader = new WeatherYahoo.WeatherDataLoader(location.ToString(), index);
                wu_Loader = new WeatherUnderground.WeatherDataLoader(location, index);

                //await wLoader.loadWeatherData().ConfigureAwait(false);
                await wu_Loader.loadWeatherData().ConfigureAwait(false);

                //WeatherYahoo.Weather weather = wLoader.getWeather();
                WeatherUnderground.Weather weather = wu_Loader.getWeather();

                if (weather != null)
                {
                    await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        if (index == 0)
                        {
                            HomePanel.First().setWeather(weather);
                            HomePanel.First().Pair = new KeyValuePair<int, object>(index, location);
                        }
                        else
                        {
                            LocationPanelView panelView = LocationPanels[index - 1];
                            panelView.setWeather(weather);

                            // Save index to tag (to easily retreive)
                            panelView.Pair = new KeyValuePair<int, object>(index, location);
                        }
                    });
                }
                else
                    throw new Exception("Weather is null");
            }

            // Refresh
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                HomeLocation.ItemsSource = null;
                OtherLocationsPanel.ItemsSource = null;
                HomeLocation.ItemsSource = HomePanel;
                OtherLocationsPanel.ItemsSource = LocationPanels;
            });
        }

        private void LocationButton_Click(object sender, RoutedEventArgs e)
        {
            LocationPanel panel = sender as LocationPanel;
            KeyValuePair<int, object> pair = (KeyValuePair<int, object>)panel.Tag;
            //wLoader = new WeatherYahoo.WeatherDataLoader(pair.Value.ToString(), pair.Key);
            wu_Loader = new WeatherUnderground.WeatherDataLoader(pair.Value.ToString(), pair.Key);

            // Save WeatherLoader
            if (CoreApplication.Properties.ContainsKey("WeatherLoader"))
            {
                CoreApplication.Properties.Remove("WeatherLoader");
            }
            CoreApplication.Properties.Add("WeatherLoader", wu_Loader);

            this.Frame.Navigate(typeof(WeatherNow));
        }

        private void ShowAddLocationsPanel(bool show)
        {
            AddLocationsButton.Visibility = show ? Visibility.Collapsed : Visibility.Visible;
            AddLocationPanel.Visibility = show ? Visibility.Visible : Visibility.Collapsed;

            if (!show)
            {
                Location.Text = string.Empty;
                Location.IsSuggestionListOpen = false;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ShowAddLocationsPanel(false);
        }

        private async void GPS_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.IsEnabled = false;

            Geolocator geolocal = new Geolocator();
            Geoposition geoPos = await geolocal.GetGeopositionAsync();

            button.IsEnabled = false;

            WeatherUnderground.location gpsLocation = await WeatherUnderground.GeopositionQuery.getLocation(geoPos);
            LocationQueryView view = new LocationQueryView(gpsLocation);

            LocationQuerys.Clear();
            LocationQuerys.Add(view);

            // Refresh list
            NewHomeLocation.ItemsSource = null;
            Location.ItemsSource = null;
            NewHomeLocation.ItemsSource = LocationQuerys;
            Location.ItemsSource = LocationQuerys;

            NewHomeLocation.IsSuggestionListOpen = true;
            Location.IsSuggestionListOpen = true;
            button.IsEnabled = true;

            /* Yahoo Code (HomeGPS)
            NewHomeLocation.BorderThickness = new Thickness(0);

            // Set window items
            HomeGPS.IsEnabled = false;

            Geolocator geolocal = new Geolocator();
            Geoposition geoPos = await geolocal.GetGeopositionAsync();
            List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
            int index = 0; // Home Location

            wLoader = new WeatherYahoo.WeatherDataLoader(geoPos, index);
            await wLoader.loadWeatherData(true).ConfigureAwait(false);

            WeatherYahoo.Weather weather = wLoader.getWeather();

            if (weather != null)
            {
                // Show location name
                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    WeatherYahoo.Coordinate location = new WeatherYahoo.Coordinate(
                        string.Join(",", wLoader.getWeather().location.lat, wLoader.getWeather().location._long));

                    // Save coords to List
                    locations[0] = location;
                    Settings.saveLocations(locations);

                    HomePanel.First().setWeather(weather);
                    // Save index to tag (to easily retreive)
                    HomePanel.First().Pair = new KeyValuePair<int, object>(index, location);

                    // Hide add locations panel
                    ShowChangeHomePanel(false);
                });
            }
            else
            {
                throw new Exception("Weather is null");

                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    NewHomeLocation.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                    NewHomeLocation.BorderThickness = new Thickness(2);
                    HomeGPS.IsEnabled = true;
                });
            }

            // Refresh
            HomeLocation.ItemsSource = null;
            HomeLocation.ItemsSource = HomePanel;

            // Re-enable Button
            HomeGPS.IsEnabled = true;
            */

            /* Yahoo Code (OtherGPS)
            Location.BorderThickness = new Thickness(0);

            List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();

            // Set window items
            OtherGPS.IsEnabled = false;

            Geolocator geolocal = new Geolocator();
            Geoposition geoPos = await geolocal.GetGeopositionAsync();
            int index = locations.Count;

            wLoader = new WeatherYahoo.WeatherDataLoader(geoPos, index);
            await wLoader.loadWeatherData(true).ConfigureAwait(false);

            WeatherYahoo.Weather weather = wLoader.getWeather();

            if (weather != null)
            {
                // Show location name
                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    WeatherYahoo.Coordinate location = new WeatherYahoo.Coordinate(
                        string.Join(",", wLoader.getWeather().location.lat, wLoader.getWeather().location._long));

                    // Save coords to List
                    locations.Add(location);
                    Settings.saveLocations(locations);

                    LocationPanelView panelView = new LocationPanelView(weather);
                    // Save index to tag (to easily retreive)
                    panelView.Pair = new KeyValuePair<int, object>(index, location);

                    // Add to collection
                    LocationPanels.Add(panelView);

                    // Hide add locations panel
                    ShowAddLocationsPanel(false);
                });
            }
            else
            {
                throw new Exception("Weather is null");

                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Location.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                    Location.BorderThickness = new Thickness(2);
                });
            }

            // Re-enable Button
            OtherGPS.IsEnabled = true;
            */
        }

        private async void Location_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            LocationPanel panel = sender as LocationPanel;
            KeyValuePair<int, object> pair = (KeyValuePair<int, object>)panel.Tag;
            int idx = pair.Key;

            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
            {
                Windows.UI.Popups.PopupMenu menu = new Windows.UI.Popups.PopupMenu();

                if (idx == 0)
                {
                    menu.Commands.Add(new Windows.UI.Popups.UICommand("Change Favorite Location", (command) =>
                    {
                        ShowChangeHomePanel(true);
                    }));
                }
                else
                {
                    menu.Commands.Add(new Windows.UI.Popups.UICommand("Delete Location", async (command) =>
                    {
                        // Remove location from list
                        //List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
                        List<string> locations = await Settings.getLocations_WU();
                        locations.RemoveAt(idx);
                        Settings.saveLocations(locations);

                        // Remove panel
                        LocationPanels.RemoveAt(idx - 1);
                    }));
                }

                Windows.UI.Popups.IUICommand chosenCommand = await menu.ShowForSelectionAsync(GetElementRect(panel)).AsTask().ConfigureAwait(false);
                if (chosenCommand == null) { } // The command is null if no command was invoked. 
            });
            e.Handled = true;
        }

        private void LocationButton_Holding(object sender, HoldingRoutedEventArgs e)
        {
            if (e.HoldingState == Windows.UI.Input.HoldingState.Started)
            {
                Button panel = sender as Button;
                panel.ReleasePointerCaptures();
                e.Handled = true;
            }
        }

        public static Rect GetElementRect(FrameworkElement element)
        {
            GeneralTransform buttonTransform = element.TransformToVisual(null);
            Point point = buttonTransform.TransformPoint(new Point());
            return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
        }

        private async void Location_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (!String.IsNullOrWhiteSpace(sender.Text) && args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                List<WeatherUnderground.AC_Location> results = await WeatherUnderground.AutoCompleteQuery.getLocations(sender.Text).ConfigureAwait(false);

                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    LocationQuerys.Clear();

                    // Show message if no results are found
                    if (results.Count == 0)
                    {
                        LocationQueryView noresults = new LocationQueryView();
                        noresults.LocationName = "No results found";
                        LocationQuerys.Add(noresults);
                    }
                    else
                    {
                        // Limit amount of results shown
                        int maxResults = 10;

                        foreach (WeatherUnderground.AC_Location location in results)
                        {
                            LocationQueryView view = new LocationQueryView(location);
                            LocationQuerys.Add(view);

                            // Limit amount of results
                            maxResults--;
                            if (maxResults <= 0)
                                break;
                        }
                    }

                    // Refresh list
                    sender.ItemsSource = null;
                    sender.ItemsSource = LocationQuerys;

                    sender.IsSuggestionListOpen = true;
                });
            }
            else if (String.IsNullOrWhiteSpace(sender.Text))
            {
                // Hide flyout if query is empty or null
                sender.IsSuggestionListOpen = false;
            }
        }

        private void Location_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            LocationQueryView theChosenOne = args.SelectedItem as LocationQueryView;

            if (theChosenOne != null)
            {
                if (String.IsNullOrEmpty(theChosenOne.LocationQuery))
                    sender.Text = String.Empty;
                else
                    sender.Text = theChosenOne.LocationName;
            }

            sender.IsSuggestionListOpen = false;
        }

        private async void Location_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
                LocationQueryView theChosenOne = args.ChosenSuggestion as LocationQueryView;

                if (!String.IsNullOrEmpty(theChosenOne.LocationQuery))
                    selected_query = theChosenOne.LocationQuery;
            }
            else if (!String.IsNullOrEmpty(args.QueryText))
            {
                // Use args.QueryText to determine what to do.
                List<WeatherUnderground.AC_Location> results = await WeatherUnderground.AutoCompleteQuery.getLocations(args.QueryText).ConfigureAwait(false);

                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (results.Count > 0)
                    {
                        sender.Text = results.First().name;
                        selected_query = results.First().l;
                    }
                });
            }

            // Save location query to List
            List<string> locations = await Settings.getLocations_WU();
            //List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
            int index = 0;

            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (sender.Name == "NewHomeLocation")
                    index = 0;
                else
                    index = locations.Count;
            });

            //wLoader = new WeatherYahoo.WeatherDataLoader(NewHomeLocation.Text, index);
            //await wLoader.loadWeatherData(true).ConfigureAwait(false);
            wu_Loader = new WeatherUnderground.WeatherDataLoader(selected_query, index);
            await wu_Loader.loadWeatherData(true).ConfigureAwait(false);

            //WeatherYahoo.Weather weather = wLoader.getWeather();
            WeatherUnderground.Weather weather = wu_Loader.getWeather();

            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (weather != null)
                {
                    // Show location name
                    /*
                    WeatherYahoo.Coordinate location = new WeatherYahoo.Coordinate(
                        string.Join(",", wLoader.getWeather().location.lat, wLoader.getWeather().location._long));
                    */

                    // Save coords to List
                    if (sender.Name == "NewHomeLocation")
                        locations[index] = selected_query;
                    else
                        locations.Add(selected_query);
                    Settings.saveLocations(locations);

                    if (index == 0)
                    {
                        HomePanel.First().setWeather(weather);
                        // Save index to tag (to easily retreive)
                        HomePanel.First().Pair = new KeyValuePair<int, object>(index, /*location*/selected_query);

                        // Hide change location panel
                        ShowChangeHomePanel(false);

                        // Refresh
                        sender.ItemsSource = null;
                        sender.ItemsSource = HomePanel;
                    }
                    else
                    {
                        LocationPanelView panelView = new LocationPanelView(weather);
                        // Save index to tag (to easily retreive)
                        panelView.Pair = new KeyValuePair<int, object>(index, /*location*/selected_query);

                        // Add to collection
                        LocationPanels.Add(panelView);

                        // Hide add locations panel
                        ShowAddLocationsPanel(false);
                    }
                }
                else
                {
                    throw new Exception("Weather is null");

                    NewHomeLocation.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                    NewHomeLocation.BorderThickness = new Thickness(5);
                }

                sender.IsSuggestionListOpen = false;
            });
        }

        #region LocationsPage HomePanelFunctions
        /* Yahoo Code
        private async void NewHomeLocation_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            NewHomeLocation.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Gray);
            NewHomeLocation.BorderThickness = new Thickness(2);

            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
                int index = 0; // Home Location

                if (!String.IsNullOrWhiteSpace(NewHomeLocation.Text))
                {
                    wLoader = new WeatherYahoo.WeatherDataLoader(NewHomeLocation.Text, index);
                    await wLoader.loadWeatherData(true).ConfigureAwait(false);

                    WeatherYahoo.Weather weather = wLoader.getWeather();

                    if (weather != null)
                    {
                        // Show location name
                        await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            WeatherYahoo.Coordinate location = new WeatherYahoo.Coordinate(
                                string.Join(",", wLoader.getWeather().location.lat, wLoader.getWeather().location._long));

                            // Save coords to List
                            locations[0] = location;
                            Settings.saveLocations(locations);

                            HomePanel.First().setWeather(weather);
                            // Save index to tag (to easily retreive)
                            HomePanel.First().Pair = new KeyValuePair<int, object>(index, location);

                            // Hide change location panel
                            ShowChangeHomePanel(false);
                        });
                    }
                    else
                    {
                        throw new Exception("Weather is null");

                        await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            NewHomeLocation.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                            NewHomeLocation.BorderThickness = new Thickness(5);
                        });
                    }
                }

                // Refresh
                HomeLocation.ItemsSource = null;
                HomeLocation.ItemsSource = HomePanel;

                e.Handled = true;
            }
        }
        */

        private void ShowChangeHomePanel(bool show)
        {
            // Hide Textbox
            ChangeHomePanel.Visibility = show ? Visibility.Visible : Visibility.Collapsed;
            // Show HomeLocation Panel
            HomeLocation.Visibility = show ? Visibility.Collapsed : Visibility.Visible;

            if (!show)
            {
                NewHomeLocation.Text = string.Empty;
                NewHomeLocation.IsSuggestionListOpen = false;
            }
        }

        private void NewHome_Cancel_Click(object sender, RoutedEventArgs e)
        {
            ShowChangeHomePanel(false);
        }
        #endregion

        #region LocationsPage OtherLocationPanelFunctions
        private void AddLocationsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAddLocationsPanel(true);
        }

        /* Yahoo Code
        private async void Location_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            Location.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Gray);
            Location.BorderThickness = new Thickness(2);

            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                List<WeatherYahoo.Coordinate> locations = await Settings.getLocations();
                int index = locations.Count;

                if (!String.IsNullOrWhiteSpace(Location.Text))
                {
                    wLoader = new WeatherYahoo.WeatherDataLoader(Location.Text, index);
                    await wLoader.loadWeatherData(true).ConfigureAwait(false);

                    WeatherYahoo.Weather weather = wLoader.getWeather();

                    if (weather != null)
                    {
                        // Show location name
                        await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            WeatherYahoo.Coordinate location = new WeatherYahoo.Coordinate(
                                string.Join(",", wLoader.getWeather().location.lat, wLoader.getWeather().location._long));

                            // Save coords to List
                            locations.Add(location);
                            Settings.saveLocations(locations);

                            LocationPanelView panelView = new LocationPanelView(weather);
                            // Save index to tag (to easily retreive)
                            panelView.Pair = new KeyValuePair<int, object>(index, location);

                            // Add to collection
                            LocationPanels.Add(panelView);

                            // Hide add locations panel
                            ShowAddLocationsPanel(false);
                        });
                    }
                    else
                    {
                        throw new Exception("Weather is null");

                        await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            Location.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                            Location.BorderThickness = new Thickness(5);
                        });
                    }
                }

                e.Handled = true;
            }
        }
        */
        #endregion
    }
}