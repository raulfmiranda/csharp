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
            Console.Write(" Digite uma frase: ");
            string frase = Console.ReadLine();
            // frase = "Este é o TEXTO. Texto, texto, TeXtO - ESTE TEXTO! Este é o texto?";
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

            // Encontrei essa dica neste link:
            // http://stackoverflow.com/questions/21411384/sort-dictionary-string-int-by-value

            foreach (var par in contaStrings.OrderBy(r => r.Value).Take(contaStrings.Count))
            {
                Console.WriteLine(" {0} -> {1}", par.Key, par.Value);
            }

            Console.ReadLine();
        }
    }
}
