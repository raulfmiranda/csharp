/*
 * Aluno: Raul Figueira Miranda
 * Exercício 6 [08/05/2017]
 * 
 * Escreva um programa que receba N e calcule a soma dos N primeiros termos da 
 * sequência de Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,…
 * Cada membro da sequência de Fibonacci (exceto os dois primeiros) é a soma dos 
 * dois membros anteriores.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace exerc6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Tamanho do array de fibonacci a ser somado: ");
            int qtdeElementos = int.Parse(Console.ReadLine());
            Console.WriteLine("Soma: " + somaFibo(qtdeElementos) + "\n");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int somaFibo(int qtdeElementos)
        {
            if(qtdeElementos >= 2)
            {
                List<int> fiboLista = new List<int>{0, 1};
                qtdeElementos -= 2;
                
                for(int i = 0; i < qtdeElementos; i++)
                {
                    fiboLista.Add(fiboLista.ElementAt(i) + fiboLista.ElementAt(i + 1));           
                }
                
                Console.WriteLine(" ");
                Console.Write("Fibonacci: ");
                
                int soma = 0;                
                for(int j = 0; j < fiboLista.Count; j++)
                {
                  soma += fiboLista.ElementAt(j);
                  Console.Write(" "+fiboLista.ElementAt(j));  
                }
                
                Console.WriteLine(" ");
                
                return soma;
            }
            else 
            {
            	return qtdeElementos;
            }     
        }
	}
}