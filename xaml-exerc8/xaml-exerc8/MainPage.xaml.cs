/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 8 [31/05/2017]
 * 
 * Write a program that shows ListView with columns that contain controls 
 * such as checkboxes and text boxes. The name of the columns are ID, Enabled, Value.
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

namespace xaml_exerc8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<Dado> dados = new List<Dado>();
            dados.Add(new Dado() { Id = 0, Selecionado = false, Valor = "valor 0" });
            dados.Add(new Dado() { Id = 1, Selecionado = true, Valor = "valor 1" });
            dados.Add(new Dado() { Id = 2, Selecionado = false, Valor = "valor 2" });
            dados.Add(new Dado() { Id = 3, Selecionado = true, Valor = "valor 3" });
        }
    }

    public class Dado
    {
        public int Id { get; set; }
        public bool Selecionado { get; set; }
        public string Valor { get; set; }
    }
}
