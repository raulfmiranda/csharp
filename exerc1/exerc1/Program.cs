/* Exercício 1  [06/05/2017]
 * Concatenação de duas strings 
 */

using System;

namespace exerc1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s1 = "Hello";
            string s2 = "World";
            object sConcat = s1 + " " + s2;
            string s3 = (string) sConcat;
            
            
            Console.WriteLine(s3);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}