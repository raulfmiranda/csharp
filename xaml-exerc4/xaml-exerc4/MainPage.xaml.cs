/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 4  [30/05/2017]
 * 
 * Escreva uma aplicação simples que ao pressionar 
 * um botão incrementa um valor exibido por uma label.
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

namespace xaml_exerc4
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

        private void btIncrementa_Click(object sender, RoutedEventArgs e)
        {
            string numStr = (string)this.tbNum.Text;
            int num = int.Parse(numStr);
            num++;
            numStr = num+"";
            this.tbNum.Text = numStr;
        }
    }
}
