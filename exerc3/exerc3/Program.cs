/*
 * Created by SharpDevelop.
 * User: 1781850
 * Date: 06/05/2017
 * Time: 15:27
 * 
 * Exercício 3.
 */
using System;

namespace exerc3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string score = Console.ReadLine();
			int resultado;
			
			switch(score)
			{
				case "1":
				case "2":
				case "3":
					resultado = int.Parse(score) * 10;
					Console.WriteLine(resultado);
					break;
				case "4":
				case "5":
				case "6":
					resultado = int.Parse(score) * 100;
					Console.WriteLine(resultado);
					break;
				case "7":
				case "8":
				case "9":
					resultado = int.Parse(score) * 1000;
					Console.WriteLine(resultado);
					break;
				default:
					Console.WriteLine("Erro");
					break;
					
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}