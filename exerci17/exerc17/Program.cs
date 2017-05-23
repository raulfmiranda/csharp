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
            List<double> nums = new List<double>();
            nums.Add(1.1);
            nums.Add(2.3);
            nums.Add(4.1);
            nums.Add(2.5);
            Console.WriteLine(" Soma: {0}\n Produto: {1}", nums.Soma(), nums.Produto());
            Console.WriteLine(" Mínimo: {0}\n Máximo: {1}\n Média: {2}", nums.Minimo(), nums.Maximo(), nums.Media());

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

        public static T Produto<T>(this IEnumerable<T> nums)
        {
            double prod = 1.0;

            foreach (T num in nums)
            {
                prod *= (double)Convert.ChangeType(num, typeof(double));
            }
            return (T)Convert.ChangeType(prod, typeof(T));
        }

        public static T Minimo<T>(this IEnumerable<T> nums)
        {
            double minimo = (double)Convert.ChangeType(nums.ElementAt(0), typeof(double));
            double numDouble = 0.0;

            foreach (T num in nums)
            {
                numDouble = (double)Convert.ChangeType(num, typeof(double));
                if (numDouble < minimo)
                {
                    minimo = numDouble;
                }
            }
            return (T)Convert.ChangeType(minimo, typeof(T));
        }

        public static T Maximo<T>(this IEnumerable<T> nums)
        {
            double maximo = (double)Convert.ChangeType(nums.ElementAt(0), typeof(double));
            double numDouble = 0.0;

            foreach (T num in nums)
            {
                numDouble = (double)Convert.ChangeType(num, typeof(double));
                if (numDouble > maximo)
                {
                    maximo = numDouble;
                }
            }
            return (T)Convert.ChangeType(maximo, typeof(T));
        }

        public static T Media<T>(this IEnumerable<T> nums)
        {
            double soma = (double)Convert.ChangeType(nums.Soma(), typeof(double));
            int quant = (int)nums.Count();
            double media = soma / quant;

            return (T)Convert.ChangeType(media, typeof(T));
        }
    }
}
