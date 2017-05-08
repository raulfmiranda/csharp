/*
 * Aluno: Raul Figueira Miranda
 * Exercício 5 [06/05/2017]
 * 
 * Escreva um programa que leia do console uma sequência 
 * de N números inteiros e retorne o maior e o menor deles.
 * 
 */
using System;

namespace exerc5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int N = 5; // N: quantidade de números a serem lidos
			Console.WriteLine("Escolha "+N+" números inteiros teclando enter após cada um deles...\n");
			int numLido = 0;
			int numMaior = numLido;
			int numMenor = numLido;
			
			for(int i = 0; i < N; i++)
			{
				Console.Write("Digite um número e tecle enter: ");
				numLido = int.Parse(Console.ReadLine());
				if(numLido > numMaior)
					numMaior = numLido;
				if(numLido < numMenor)
					numMenor = numLido;
			}
			
			Console.WriteLine("\nNúmero maior: "+numMaior+"\nNúmero menor: "+numMenor+"\n");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}