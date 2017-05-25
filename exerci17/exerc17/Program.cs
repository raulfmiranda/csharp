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
            List<double> numsDouble = new List<double>();
            numsDouble.Add(1.1);
            numsDouble.Add(2.3);
            numsDouble.Add(4.1);
            numsDouble.Add(2.5);
            Console.Write("\n { ");

            foreach(double numDouble in numsDouble)
            {
                Console.Write(" {0} ", numDouble);
            }

            Console.Write(" }\n");
            Console.WriteLine("\n Soma: {0}\n Produto: {1}", numsDouble.Soma(), numsDouble.Produto());
            Console.WriteLine(" Mínimo: {0}\n Máximo: {1}\n Média: {2}", numsDouble.Minimo(), numsDouble.Maximo(), numsDouble.Media());

            List<int> numsInt = new List<int>();
            numsInt.Add(1);
            numsInt.Add(3);
            numsInt.Add(4);
            numsInt.Add(5);
            Console.Write("\n { ");

            foreach (int numInt in numsInt)
            {
                Console.Write(" {0} ", numInt);
            }

            Console.Write(" }\n");
            Console.WriteLine("\n Soma: {0}\n Produto: {1}", numsInt.Soma(), numsInt.Produto());
            Console.WriteLine(" Mínimo: {0}\n Máximo: {1}\n Média: {2}", numsInt.Minimo(), numsInt.Maximo(), numsInt.Media());

            Console.ReadLine();
        }
    }

    public static class IEnumerableExtensoes
    {
        public static T Soma<T>(this IEnumerable<T> nums)
        {
            double soma = 0.0;

            Type t = nums.GetType();
            bool isList = t.IsGenericType && t.GetGenericTypeDefinition() == typeof(List<>);

            if (isList)
            {
                foreach (T num in nums)
                {
                    soma += (double)Convert.ChangeType(num, typeof(double));
                }
                return (T)Convert.ChangeType(soma, typeof(T));
            }
            // retorna -1.0 se não for uma lista
            return (T)Convert.ChangeType(-1.0, typeof(T));
        }

        public static T Produto<T>(this IEnumerable<T> nums)
        {
            double prod = 1.0;

            Type t = nums.GetType();
            bool isList = t.IsGenericType && t.GetGenericTypeDefinition() == typeof(List<>);

            if (isList)
            {
                foreach (T num in nums)
                {
                    prod *= (double)Convert.ChangeType(num, typeof(double));
                }
                return (T)Convert.ChangeType(prod, typeof(T));
            }
            // retorna -1.0 se não for uma lista
            return (T)Convert.ChangeType(-1.0, typeof(T));
        }

        public static T Minimo<T>(this IEnumerable<T> nums)
        {     
            double numDouble = 0.0;

            Type t = nums.GetType();
            bool isList = t.IsGenericType && t.GetGenericTypeDefinition() == typeof(List<>);

            if (isList)
            {
                double minimo = (double)Convert.ChangeType(nums.ElementAt(0), typeof(double));

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
            // retorna -1.0 se não for uma lista
            return (T)Convert.ChangeType(-1.0, typeof(T));
        }

        public static T Maximo<T>(this IEnumerable<T> nums)
        {          
            double numDouble = 0.0;

            Type t = nums.GetType();
            bool isList = t.IsGenericType && t.GetGenericTypeDefinition() == typeof(List<>);

            if (isList)
            {
                double maximo = (double)Convert.ChangeType(nums.ElementAt(0), typeof(double));

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
            // retorna -1.0 se não for uma lista
            return (T)Convert.ChangeType(-1.0, typeof(T));
        }

        public static double Media<T>(this IEnumerable<T> nums)
        {
            Type t = nums.GetType();
            bool isList = t.IsGenericType && t.GetGenericTypeDefinition() == typeof(List<>);

            if (isList)
            {
                double soma = (double)Convert.ChangeType(nums.Soma(), typeof(double));
                int quant = (int)nums.Count();
                double media = soma / quant;

                return media;
            }
            // retorna -1.0 se não for uma lista
            return -1.0;
        }
    }
}
