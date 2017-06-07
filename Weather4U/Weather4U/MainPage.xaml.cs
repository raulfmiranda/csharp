﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Weather4U
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cityTextBox != null && cityTextBox.Text != "")
            {
                string city = cityTextBox.Text;
                RootObject weatherSearch = await WeatherBox.GetWeather(city);
                weatherSearch.dateTime = DateTime.Now;

                nameCountryTextBlock.Text = 
                    weatherSearch.name + " - " + weatherSearch.sys.country;
                mainDescriptionTextBlock.Text =
                    weatherSearch.weather[0].main + ": " + weatherSearch.weather[0].description;

                string tempStr = weatherSearch.main.temp + "";
                double kelvin = double.Parse(tempStr);
                tempTextBlock.Text = kelvin + " K ( " + (kelvin - 273.15) + " ºC )";

                tempStr = weatherSearch.main.temp_min + "";
                kelvin = double.Parse(tempStr);
                tempMinTextBlock.Text = kelvin + " K ( " + (kelvin - 273.15) + " ºC )";

                tempStr = weatherSearch.main.temp_max + "";
                kelvin = double.Parse(tempStr);
                tempMaxTextBlock.Text = kelvin + " K ( " + (kelvin - 273.15) + " ºC )";

                string imagePath = "ms-appx:///Assets/" + weatherSearch.weather[0].icon + ".png";
                Uri uri = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                iconImage.Source = new BitmapImage(uri);

                dateTimeTextBlock.Text = DateTime.Now.ToString();

                weatherGrid.Visibility = Visibility.Visible;
            }
            else
            {
                nameCountryTextBlock.Text = "Enter with a city name inside de textbox above.";
            }     
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SavedWeathersPage));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }
    }
}