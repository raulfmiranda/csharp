/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 10  [15/05/2017]
 * 
 * Escreva um programa que encontra o número mais frequente dentro de um array. 
 * Exemplo:
 * {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int biggestValue = 0;
            int mostRepeatedKey = 0;
            Dictionary<int, int> countDic = new Dictionary<int, int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (countDic.ContainsKey(array[i]))
                {
                    countDic[array[i]]++;
                }
                else
                {
                    countDic.Add(array[i], 1);
                }
            }

            foreach (int key in countDic.Keys)
            {
                if (countDic[key] > biggestValue)
                {
                    biggestValue = countDic[key];
                    mostRepeatedKey = key;
                }
            }

            if (biggestValue > 0)
            {
                Console.WriteLine(mostRepeatedKey + " (" + biggestValue + " times)");
            }

            Console.ReadLine();
        }
    }
}
