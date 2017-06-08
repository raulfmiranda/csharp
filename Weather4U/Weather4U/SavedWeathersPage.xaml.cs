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
using Windows.UI.Core;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Weather4U
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SavedWeathersPage : Page
    {
        private WeatherController weatherCtrl;
        private RootObject lastSelectedItem;
        private RootObject lastDeselectedItem;

        public SavedWeathersPage()
        {
            this.InitializeComponent();
            backButton.Content = "< Go Back to Search Weather Page";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {                       
            if(e.Parameter != null && weatherCtrl == null)
            {
                weatherCtrl = (WeatherController)e.Parameter;                                
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var weathers = weatherCtrl.weathers;

            foreach(RootObject weather in weathers)
            {
                weather.backgroundColor = new SolidColorBrush(Colors.Beige);
            }          
            
            lastSelectedItem = null;
            lastDeselectedItem = null;

            Frame.Navigate(typeof(MainPage), weatherCtrl);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(lastSelectedItem != null)
            {
                weatherCtrl.delWeather(lastSelectedItem);
                weathersListView.ItemsSource = weatherCtrl.weathers;
                systemMsgTextBlock.Text = "Item deleted!";
            }
            else
            {
                systemMsgTextBlock.Text = "Select an item before delete it.";
            }
        }

        private void weathersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IList<object> selectedItems = e.AddedItems as IList<object>;
            IList<object> deselectedItems = e.RemovedItems as IList<object>;

            if (selectedItems != null && selectedItems.Count > 0)
            {
                lastSelectedItem = selectedItems[selectedItems.Count - 1] as RootObject;
                lastSelectedItem.backgroundColor = new SolidColorBrush(Colors.LightBlue);                
            }

            if(deselectedItems != null && deselectedItems.Count > 0)
            {
                lastDeselectedItem = deselectedItems[deselectedItems.Count - 1] as RootObject;
                lastDeselectedItem.backgroundColor = new SolidColorBrush(Colors.Beige);
            }
            
            weathersListView.ItemsSource = weatherCtrl.weathers;
        }        
    }    
}
