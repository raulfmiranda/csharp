/* 
 * Aluno: Raul Figueira Miranda
 * XAML - Exercício 5  [30/05/2017]
 * 
 * Crie uma aplicação que adiciona dinamicamente um botão na tela, 
 * com o título informado em um TextBox, que ao pressionado exibe 
 * a mensagem: “Clique do botão <NomeBotão>!”.
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

namespace xaml_exerc5
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

        private void btCriarBotao_Click(object sender, RoutedEventArgs e)
        {
            string nomeBotao = this.tbNomeBotao.Text;

            if(!nomeBotao.Equals("") && nomeBotao != null)
            {
                Button novoBotao = new Button();
                novoBotao.Content = nomeBotao;
                novoBotao.HorizontalAlignment = HorizontalAlignment.Stretch;
                novoBotao.Click += this.btClicado;

                this.stackPanel.Children.Add(novoBotao);                
            }
        }

        private void btClicado(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                string nomeBotao = (string)(sender as Button).Content;
                this.tbNomeBotao.Text = "Meu nome é " + nomeBotao;
            }
        }
    }
}
