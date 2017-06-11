/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 13 [11/06/2017]
 * 
 * Add to the previous exercise few buttons each of which applies 
 * a preset value to the slider. When you click the "Set to Large" button 
 * the code in Click event sets the value of the slider, which in turn 
 * forces a change to the font size of the text through data binding.
 *
 */

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

namespace xaml_exerci13
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FontSizeSlider.Value = 30;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FontSizeSlider.Value = 10;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FontSizeSlider.Value = 20;
        }
    }
}
