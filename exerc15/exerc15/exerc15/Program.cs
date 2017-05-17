/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 15  [17/05/2017]
 * 
 * Escreva um programa que leia dois números como string e retorne a divisão do primeiro pelo segundo. 
 * Use a construção try-catch para tratar todas as possíveis exceções de modo específico.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número (numerador): ");
                double numerador = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.Write("Digite um número (denominador): ");
                double denominador = double.Parse(Console.ReadLine().Replace('.', ','));
                double resultado = numerador / denominador;

                if(double.IsInfinity(resultado))
                {
                    throw new ArithmeticException();
                }

                Console.WriteLine("( {0} / {1} ) = {2}", numerador, denominador, numerador / denominador);
            }
            catch(FormatException)
            {
                Console.WriteLine("\n\n > Número inválido!");
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("\n\n > O denominador não pode ser zero!");
            }
            
            

            Console.ReadLine();
        }
    }
}
