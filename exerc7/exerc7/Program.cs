/*
 * Aluno: Raul Figueira Miranda
 * Exercício 7 [08/05/2017]
 * 
 * Escreva um programa que leia do console um número inteiro positivo N (N < 20) 
 * e escreva no console a matriz correspondente
 * 
 */
using System;

namespace exerc7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = 0;
			bool invalido = true;
            
            do
            {
                Console.Write("Tamanho da matriz quadrada: ");
                n = int.Parse(Console.ReadLine());
                invalido = (n > 20 || n < 1);
                Console.WriteLine("");
                
                if(invalido)
                {
                   Console.WriteLine("O tamanho deve ser um número inteiro positivo menor que 20.");
                   Console.WriteLine("");
                }   
                
            } while(invalido);
            
            int count = 0;
            for(int i = 1; count < n*n; i++)
            {
                count++;
                if(i < 10)
                {
                    Console.Write("  "+i+"  ");
                }
                else if(i >= 10 && i < 100)
                {
                    Console.Write("  "+i+" ");
                }
                else
                {
                    Console.Write("  "+i);
                }
                
                if(count % n == 0)
                {
                   Console.WriteLine("");
                   i -= n - 1;
                }
                    
            }
			
			// TODO: Implement Functionality Here
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}