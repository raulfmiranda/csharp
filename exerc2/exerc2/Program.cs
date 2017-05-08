/*
 * Created by Raul.
 * User: 1781850
 * Date: 06/05/2017
 * Time: 14:45
 * 
 * Exercício 2: encontrar maior valor entre 5 variáveis dadas.
 */
using System;

namespace exerc2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[] numeros = new double[5] {1, 3.7, 3.1, 3, -5};
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