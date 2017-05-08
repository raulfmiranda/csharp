/*
 * Aluno: Raul Figueira Miranda
 * Exercício 2 [06/05/2017]
 * 
 * Escreva um programa que encontra o maior valor entre 5 variáveis dadas.
 * 
 */
using System;

namespace exerc2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[] numeros = new double[5] {1, 3.7, 3.1, 10, -5};
			double maior = numeros[0];
			int tamanho = numeros.Length;
			
			if(tamanho > 1)
			{
				for(int i = 1; i < tamanho; i++)
				{
					if(numeros[i] > maior)
						maior = numeros[i];
				}
			}
			
			Console.WriteLine("O maior número é " + maior);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}