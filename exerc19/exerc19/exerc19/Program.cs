/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 19  [20/05/2017]
 * 
 * Escreva um método de extensão para classe String que torne maiúscula 
 * a primeira letra de cada palavra. Use o método TextInfo.ToTitleCase().
 * 
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "deixe o seu sorriso mudar o mundo, mas não deixe o mundo mudar seu sorriso.";
            Console.WriteLine(str.firstLetterUpperCase());

            Console.ReadLine();
        }
    }

    public static class StringExtensoes
    {
        public static string firstLetterUpperCase(this string str)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            str = textInfo.ToTitleCase(str);
            return str;
        }
    }
}
