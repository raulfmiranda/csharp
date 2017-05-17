/*
 * Aluno: Raul Figueira Miranda
 * Exercício 13 [15/05/2017]
 * 
 * Escreva um programa que conta quantas vezes uma palavra aparece em uma frase recebida no console. 
 * Não deve ser feita distinção entre maiúsculas e minúsculas. O resultado deve ser ordenado pelo 
 * número de incidências da palavra. 
 * 
 * Exemplo: Este é o TEXTO. Texto, texto, TeXtO – ESTE TEXTO! Este é o texto?
 * 
 * é -> 2 
 * o -> 2
 * este -> 3
 * texto -> 6
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc13
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Este é o TEXTO. Texto, texto, TeXtO - ESTE TEXTO! Este é o texto?";
            // Console.WriteLine(" Digite uma frase: ");
            // string frase = Console.ReadLine();
            frase = frase.ToLower();

            char c;
            for (int j = 0; j < frase.Length; j++)
            {
                c = frase[j];

                if (c > 32 && c < 65)
                {
                    frase = frase.Replace(c, '\0');
                }
            }

            Console.WriteLine(frase);

            char delimitador = ' ';
            string[] substrings = frase.Split(delimitador);

            for (int k = 0; k < substrings.Length; k++)
            {
                substrings[k] = substrings[k].Trim(new Char[] { '\0' });
            }

            Dictionary<string, int> contaStrings = new Dictionary<string, int>();
            int strLength;
            for (int i = 0; i < substrings.Length; i++)
            {
                if (!contaStrings.ContainsKey(substrings[i]))
                {
                    strLength = substrings[i].Length;
                    if (strLength > 0)
                        contaStrings.Add(substrings[i], 1);
                }
                else
                {
                    contaStrings[substrings[i]]++;
                }
            }

            foreach (string key in contaStrings.Keys)
            {
                Console.WriteLine(key + " -> " + contaStrings[key]);
            }

            Console.ReadLine();
        }
    }
}
