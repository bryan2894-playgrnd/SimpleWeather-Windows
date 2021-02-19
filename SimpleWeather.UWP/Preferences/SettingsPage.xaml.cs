﻿using SimpleWeather.Utils;
using SimpleWeather.UWP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace SimpleWeather.UWP.Preferences
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page, ICommandBarPage, IBackRequestedPage
    {
        public string CommandBarLabel { get; set; }
        public List<muxc.NavigationViewItemBase> PrimaryCommands { get; set; }

        // List of ValueTuple holding the Navigation Tag and the relative Navigation Page
        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            ("General", typeof(Settings_General)),
            ("Features", typeof(Settings_Features)),
            ("Icons", typeof(Settings_Icons)),
            ("Units", typeof(Settings_Units)),
            ("Credits", typeof(Settings_Credits)),
            ("OSSLibs", typeof(Settings_OSSLibs)),
            ("About", typeof(Settings_About)),
        };

        public SettingsPage()
        {
            this.InitializeComponent();

            // CommandBar
            CommandBarLabel = App.ResLoader.GetString("Nav_Settings/Content");
            AnalyticsLogger.LogEvent("SettingsPage");

            if (ApiInformation.IsTypePresent("Windows.Services.Store.StoreContext"))
            {
                _pages.Add(("Premium", typeof(Extras.Store.PremiumPage)));
                SettingsNavView.MenuItems.Insert(SettingsNavView.MenuItems.Count - 1, new muxc.NavigationViewItem()
                {
                    Icon = new SymbolIcon(Symbol.SolidStar),
                    Content = "Premium",
                    Tag = "Premium"
                });
            }
        }

        public Task<bool> OnBackRequested()
        {
            if (SettingsFrame?.Content is IBackRequestedPage backRequestedPage)
            {
                return backRequestedPage.OnBackRequested();
            }

            return Task.FromResult(false);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            AnalyticsLogger.LogEvent("SettingsPage: OnNavigatedTo");

            if (e?.Parameter != null)
            {
                Type _page = null;
                var item = _pages.FirstOrDefault(p => p.Tag.Equals(e.Parameter.ToString()));
                _page = item.Page;
                if (_page != null)
                {
                    SettingsFrame.Navigate(_page, new Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo());
                }
            }
            else
            {
                // NavView doesn't load any page by default, so load home page.
                SettingsNavView.SelectedItem = SettingsNavView.MenuItems[0];
                SettingsNavView_Navigate("General", new Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo());
            }
        }

        private void SettingsNavView_ItemInvoked(muxc.NavigationView sender, muxc.NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                SettingsNavView_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);

                AnalyticsLogger.LogEvent("SettingsPage: NavigationView_SelectionChanged",
                    new Dictionary<string, string>()
                    {
                        { "PageType", navItemTag }
                    });
            }
        }

        private void SettingsNavView_Navigate(
            string navItemTag,
            Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
            _page = item.Page;
            // Get the page type before navigation so you can prevent duplicate
            // entries in the backstack.
            var preNavPageType = SettingsFrame.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
                SettingsFrame.Navigate(_page, null, transitionInfo);
            }
        }

        private void SettingsFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (SettingsFrame?.Content is Page page && VisualTreeHelperExtensions.FindChild<ScrollViewer>(page.Content as FrameworkElement, null, true) is ScrollViewer scrollViewer)
            {
                // NOTE: ChangeView does not work here for some reason
                scrollViewer.ScrollToVerticalOffset(0);
            }
            if (SettingsFrame?.Content is IFrameContentPage contentPage)
            {
                contentPage.OnNavigatedToPage(e);
            }

            if (SettingsFrame.SourcePageType != null)
            {
                var item = _pages.FirstOrDefault(p => p.Page == e.SourcePageType);

                SettingsNavView.SelectedItem = SettingsNavView.MenuItems
                    .OfType<muxc.NavigationViewItem>()
                    .FirstOrDefault(n => n.Tag.Equals(item.Tag));
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            if (SettingsFrame?.Content is IFrameContentPage contentPage)
            {
                contentPage.OnNavigatedFromPage(e);
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);

            if (SettingsFrame?.Content is IFrameContentPage contentPage)
            {
                contentPage.OnNavigatingFromPage(e);
            }
        }
    }
}