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
        private List<RootObject> weathers;
        private IList<object> selectedItems;
        private IList<object> removedItems;

        public SavedWeathersPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {                       
            if(e.Parameter != null)
            {
                weathers = (List<RootObject>)e.Parameter;                                
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(RootObject weather in weathers)
            {
                weather.backgroundColor = new SolidColorBrush(Colors.Beige);
            }
            selectedItems = null;
            removedItems = null;

            Frame.Navigate(typeof(MainPage), weathers);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            if(itemClicked != null)
            {
                for(int i = 0; i < weathers.Count; i++)
                {
                    if(itemClicked.id == weathers[i].id)
                    {
                        weathers.RemoveAt(i);
                        systemMsgTextBlock.Text = "Weather was deleted!";
                        return;
                    }
                }
            }*/
        }

        private void weathersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItems = e.AddedItems as IList<object>;
            removedItems = e.RemovedItems as IList<object>;

            RootObject lastItemSelected;
            RootObject lastItemRemoved;

            if (selectedItems != null && selectedItems.Count > 0)
            {
                lastItemSelected = selectedItems[selectedItems.Count - 1] as RootObject;
                lastItemSelected.backgroundColor = new SolidColorBrush(Colors.LightBlue);
            }

            if(removedItems != null && removedItems.Count > 0)
            {
                lastItemRemoved = removedItems[removedItems.Count - 1] as RootObject;
                lastItemRemoved.backgroundColor = new SolidColorBrush(Colors.Beige);
            }

            weathersListView.ItemsSource = weathers;
        }
        
    }

    
}
