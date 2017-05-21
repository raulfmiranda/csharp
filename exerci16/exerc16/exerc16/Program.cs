/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 16  [17/05/2017]
 * 
 * Implemente um método de extensão Substring(int index, int length) 
 * para a classe StringBuilder que retorne uma nova StringBuilder e 
 * tenha a mesma funcionalidade do método Substring na classe String.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc16
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("0123456789");
            Console.WriteLine("\n stringBuilder = '{0}'", stringBuilder.ToString());
            StringBuilder subStrBuilder = stringBuilder.Substring(3, 4);
            Console.WriteLine(" stringBuilder.Substring(3, 4) = '{0}'", subStrBuilder.ToString());
            Console.ReadLine();
        }       
    }

    static class StringBuilderExtensoes
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            string str = stringBuilder.ToString();
            string subStr = str.Substring(index, length);

            return new StringBuilder(subStr);
        }
    }
}
