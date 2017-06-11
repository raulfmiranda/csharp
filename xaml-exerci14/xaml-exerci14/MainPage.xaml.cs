/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 14 [11/06/2017]
 * 
 * Write a program that shows a simple window, which contains a TextBlock
 * and setup the TextBlock to draw its text from a TextBox and its current 
 * foreground and background colors from separate lists of colors.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xaml_exerci14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Colorful colorful;

        public MainPage()
        {
            this.InitializeComponent();

            colorful = new Colorful();
            DataContext = colorful;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Random rand = new Random();
            int index = rand.Next(0, colorful.colorList.Count);
            colorful.Foreground = new SolidColorBrush(colorful.colorList.ElementAt(index));
            index = rand.Next(0, colorful.colorList.Count);
            colorful.Background = new SolidColorBrush(colorful.colorList.ElementAt(index));
        }
    }

    public class Colorful : INotifyPropertyChanged
    {
        private SolidColorBrush foreground;
        private SolidColorBrush background;

        public SolidColorBrush Foreground
        {
            get { return foreground; }
            set
            {
                foreground = value;
                RaisePropertyChanged("Foreground");
            }
        }        

        public SolidColorBrush Background
        {
            get { return background; }
            set
            {
                background = value;                
                RaisePropertyChanged("Background");
            }
        }

        public List<Color> colorList { get; set; }

        public Colorful()
        {
            Foreground = new SolidColorBrush(Colors.White);
            Background = new SolidColorBrush(Colors.Black);

            colorList = new List<Color>();
            
            colorList.Add(Colors.Blue);
            colorList.Add(Colors.Red);
            colorList.Add(Colors.Gray);
            colorList.Add(Colors.Gold);
            colorList.Add(Colors.Pink);
            colorList.Add(Colors.Silver);
            colorList.Add(Colors.Black);
            colorList.Add(Colors.White);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
