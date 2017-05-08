/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 1  [06/05/2017]
 * 
 * Declare duas variáveis string e atribua a elas os valores “Hello” e “World”. 
 * Declare uma variável do tipo object e atribua a ela a concatenação das duas 
 * primeiras variáveis (adicione um espaço entre ambas). Declare uma terceira variável string 
 * e a inicialize com o valor da variável do tipo object criada anteriormente 
 * (será preciso fazer um type casting).
 * 
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