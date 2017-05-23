/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 17  [17/05/2017]
 * 
 * Implemente um conjunto de métodos de extensão para IEnumerable<T> 
 * que forneça as seguintes funcionalidades: soma, produto, mínimo, máximo, média.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ints = new List<double>();
            ints.Add(1.1);
            ints.Add(2.3);
            Console.WriteLine(ints.Soma());

            Console.ReadLine();
        }
    }

    public static class IEnumerableExtensoes
    {
        public static T Soma<T>(this IEnumerable<T> nums)
        {
            double soma = 0.0;

            foreach (T num in nums)
            {
                soma += (double)Convert.ChangeType(num, typeof(double));
            }
            return (T)Convert.ChangeType(soma, typeof(T));
        }

        public static T Media<T>(this IEnumerable<T> nums)
        {
            double soma = (double)Convert.ChangeType(nums.Soma(), typeof(double));
            //int quant = (int)nums.Count; 
            
            return (T)Convert.ChangeType(soma, typeof(T));
        }
    }
}
