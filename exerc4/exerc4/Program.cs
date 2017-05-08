/*
 * Created by SharpDevelop.
 * User: 1781850
 * Date: 06/05/2017
 * Time: 15:49
 * 
 * Exercício 4.
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
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}