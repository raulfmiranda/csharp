/*
 * Created by SharpDevelop.
 * User: 1781850
 * Date: 06/05/2017
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace exerc5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int N = 3;
			int count = 0;
			int numLido = int.Parse(Console.ReadLine());
			int numMaior = numLido;
			int numMenor = numLido;			
			
			for(int i = 1; i < N; i++)
			{
				numLido = int.Parse(Console.ReadLine());
				if(numLido > numMaior)
					numMaior = numLido;
				if(numLido < numMenor)
					numMenor = numLido;
			}
			
			Console.WriteLine(" Número maior: "+numMaior+" Número menor: "+numMenor);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}