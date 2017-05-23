/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 8  [13/05/2017]
 * 
 * Escreva um programa que declara um array de 20 inteiros e 
 * inicializa cada elemento pelo seu índice multiplicado por 6. 
 * Imprima o array obitido no console.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i * 6;
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
