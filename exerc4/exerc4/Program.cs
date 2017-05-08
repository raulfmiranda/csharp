/*
 * Aluno: Raul Figueira Miranda
 * Exercício 4 [06/05/2017]
 * 
 * Escreva um programa que imprima todos os números de 1 até N 
 * que não sejam divisíveis por 3 e por 7 ao mesmo tempo.
 * 
 */
using System;

namespace exerc4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int N = 100;
			for(int i = 1; i <= N; i++)
			{
				if(i % 3 == 0 && i % 7 == 0)
					continue;
				
				Console.Write(" "+i);
			}
			
			Console.WriteLine("");			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}