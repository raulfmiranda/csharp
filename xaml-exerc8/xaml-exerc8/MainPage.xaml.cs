/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 8 [31/05/2017]
 * 
 * Write a program that shows ListView with columns that contain controls 
 * such as checkboxes and text boxes. The name of the columns are ID, Enabled, Value.
 *
 *  Fonte Pesquisa: https://www.youtube.com/watch?v=zuJZrLkKGUw 
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
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xaml_exerc8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Dado> Dados;
        public MainPage()
        {
            this.InitializeComponent();

            Dados = new List<Dado>();
            Dados.Add(new Dado() { Id = 0, Enabled = false, Value = "valor 0" });
            Dados.Add(new Dado() { Id = 1, Enabled = true, Value = "valor 1" });
            Dados.Add(new Dado() { Id = 2, Enabled = false, Value = "valor 2" });
            Dados.Add(new Dado() { Id = 3, Enabled = true, Value = "valor 3" });            
        }
    }

    public class Dado
    {
        public int Id { get; set; }
        public Boolean? Enabled { get; set; }
        public string Value { get; set; }
    }
}
