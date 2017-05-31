/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 6  [31/05/2017]
 * 
 * Write a program that show the simple window with one TextBox. 
 * Add text to the TextBox. If you select some text in the TextBox  
 * – display the current selection information.
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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xaml_exerc6
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

        private void tBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(tBox.SelectionLength > 0)
            {
                tBlock.Text = tBox.SelectedText;
            }
        }
    }
}
