/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 12 [09/06/2017]
 * 
 * Write a program that show a simple window, it contains two controls 
 * a Slider and a TextBlock with a single line of text. 
 * If you pull the thumb in the slider to the right, the font size of 
 * the text is increased immediately. Add a label that shows the current font size. 
 * Use data binding.
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

namespace xaml_exerci12
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
    }
}
