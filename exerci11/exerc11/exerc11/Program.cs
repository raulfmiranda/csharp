/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 11  [15/05/2017]
 * 
 * Escreva um programa que cria um array contendo todas as letras do alfabeto (A-Z). 
 * Leia uma palavra do console e imprima o índice de cada letra que a compõe.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int UPPER_MARGIN = 65;
            const int MAX_LETRAS = 26;
            char[] alfabeto = new char[MAX_LETRAS];
            string palavra = "";

            for(int i = 0; i < MAX_LETRAS; i++)
            {
                alfabeto[i] = (char)(i + UPPER_MARGIN);
                Console.Write(alfabeto[i] + " ");
            }

            Console.Write("\nDigite uma palavra: ");
            palavra = Console.ReadLine();
            palavra = palavra.ToUpper();
            Console.WriteLine();

            int indice;
            foreach(char letra in palavra)
            {
                indice = (int)letra - UPPER_MARGIN;
                Console.WriteLine(" " + letra + " no índice " + indice);
            }

            Console.ReadLine();
        }
    }
}
