using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
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

                nameCountryTextBlock.Text = 
                    weatherSearch.name + " - " + weatherSearch.sys.country;
                iconTextBlock.Text = weatherSearch.weather[0].icon;
                mainDescriptionTextBlock.Text =
                    weatherSearch.weather[0].main + ": " + weatherSearch.weather[0].description;
                tempTextBlock.Text = weatherSearch.main.temp + "";
                tempMinTextBlock.Text = weatherSearch.main.temp_min + "";
                tempMaxTextBlock.Text = weatherSearch.main.temp_max + "";
            }
            else
            {
                nameCountryTextBlock.Text = "Enter with a city name inside de textbox above.";
            }     
        }
    }
}
