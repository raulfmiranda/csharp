/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 9 [01/06/2017]
 * 
 * Create the following
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

namespace xaml_exerc9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.textBlock1.Text = "Some\nText";
            this.textBlock2.Text = "Some\nText";
            this.textBlock3.Text = "Some\nText";
            this.textBlock4.Text = "Some\nText";
            this.textBlock5.Text = "Some\nText";
            this.textBlock6.Text = "Some\nText";
            this.textBlock7.Text = "Some\nText";
            this.textBlock8.Text = "Some\nText";
            this.textBlock9.Text = "Some\nText";
        }
    }
}
