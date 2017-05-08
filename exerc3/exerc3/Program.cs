/*
 * Aluno: Raul Figueira Miranda
 * Exercício 3 [06/05/2017]
 * 
 * Escreva um programa que aplica um fator de bônus para um dado escore no intervalo [1..9]. 
 * O programa deve ler o escore como um dígito na entrada. Se o dígito está entre 1 e 3, o programa 
 * deve multiplicá-lo por 10; se estiver entre 4 e 6, multiplica por 100; se tiver entre 7 e 9, 
 * multiplica por 1000. Se a entrada for zero ou outro valor não numérico o programa deve relatar 
 * um erro. Use a instrução switch e imprima o novo valor calculado no console. 
 * 
 */
using System;

namespace exerc3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string score = Console.ReadLine();
			int resultado = -1;
			string msgErro = "Erro: entre com um valor de 1 a 9.";
			
			switch(score)
			{
				case "1":
				case "2":
				case "3":
					resultado = int.Parse(score) * 10;
					break;
				case "4":
				case "5":
				case "6":
					resultado = int.Parse(score) * 100;
					break;
				case "7":
				case "8":
				case "9":
					resultado = int.Parse(score) * 1000;
					break;
			}
			
			if(resultado != -1)
			{
				Console.WriteLine("Resultado: "+resultado);
			}
			else
			{
				Console.WriteLine(msgErro);
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}