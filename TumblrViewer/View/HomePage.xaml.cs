﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using TumblrViewer.Model;
using TumblrViewer.ViewModel;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TumblrViewer.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        UserPageViewModel _userPageViewModel;
        ResourceLoader resourceLoader ;
        public HomePage()
        {
            _userPageViewModel = new UserPageViewModel();

            this.InitializeComponent();
            this.DataContext = _userPageViewModel;
            this.NavigationCacheMode = NavigationCacheMode.Required;
            NavPane.InitializeDrawerLayout();
            Windows.UI.ViewManagement.StatusBar.GetForCurrentView().BackgroundColor = Color.FromArgb(1, 78, 101, 135);

            resourceLoader = new ResourceLoader();

            //TMP MOCKED MENU
            List<string> menuItemsTop = new List<string> { ResourceLoader.GetForCurrentView().GetString("Home"), ResourceLoader.GetForCurrentView().GetString("Followers") };
            MenuItems.ItemsSource = menuItemsTop;

            List<string> menuItemsBottom = new List<string> { ResourceLoader.GetForCurrentView().GetString("Settings"), ResourceLoader.GetForCurrentView().GetString("Login") };
            MenuItemsBottom.ItemsSource = menuItemsBottom;
        }

        private async void SearchIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NavPane.IsDrawerOpen)
            {
                NavPane.CloseDrawer();
            }
                
            if (SearchBox.Visibility == Visibility.Collapsed)
            {
                SearchBox.Visibility = Visibility.Visible;
                MainPageHeader.Visibility = Visibility.Collapsed;
            }
            else
            {
                SearchBox.Visibility = Visibility.Collapsed;
                MainPageHeader.Visibility = Visibility.Visible;
            }
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => SearchBox.Focus(FocusState.Keyboard));
        }

        private void MenuIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NavPane.IsDrawerOpen)
                NavPane.CloseDrawer();
            else
                NavPane.OpenDrawer();
        }

        private void MenuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MenuItems.SelectedItem != null)
            {
                var selecteditem = MenuItems.SelectedValue as string;
                NavPane.CloseDrawer();
                MenuItems.SelectedItem = null;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            Windows.Phone.UI.Input.HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainListView.SelectedItem = null;
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }
        void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if (NavPane.IsDrawerOpen)
            {
                NavPane.CloseDrawer();
                e.Handled = true;
            }
            else
            {
                Application.Current.Exit();
            }
        }

        private void SearchButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _userPageViewModel.SendRequest();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text != String.Empty)
            {
                SearchIcon.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Visible;
            }
            else
            {
                SearchButton.Visibility = Visibility.Collapsed;
                SearchIcon.Visibility = Visibility.Visible;
            }
        }

        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tumblrPostsPost itemId = ((sender as ListView).SelectedItem as tumblrPostsPost);
            if (itemId != null)
            {
                if (itemId.type.Equals("photo"))
                {
                    Frame.Navigate(typeof(PostPage), itemId);
                }
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            _userPageViewModel.Reverse();
        }

        private void SearchBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NavPane.IsDrawerOpen)
            {
                NavPane.CloseDrawer();
            }
        }
    }
}