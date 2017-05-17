/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 14  [17/05/2017]
 * 
 * Escreva um programa que leia um número inteiro, calcule sua raíz quadrada 
 * e imprima o resultado. Se o número for inválido ou negativo imprima “Número inválido”. 
 * Em todo os casos imprima no final "Good bye". Use a construção try-catch-finally.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exerc14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                string numIntStr = Console.ReadLine();

                if (!Regex.IsMatch(numIntStr, @"^\d+$"))
                {
                    throw new ArithmeticException();
                }
                else
                {
                    double raiz = Math.Sqrt(double.Parse(numIntStr));
                    Console.Write("\n > Raiz: {0}", raiz);
                }
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("\n > Número inválido");
            }
            finally
            {
                Console.WriteLine("\n\nGood bye");
            }

            Console.ReadLine();
        }
    }
}
