using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 2, 3, 4, 2, 2, 4};

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.ReadLine();
        }
    }
}
