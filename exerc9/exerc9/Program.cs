/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 9  [15/05/2017]
 * 
 * Escreva um programa que encontra a maior sequência incremental dentro de um array. 
 * Exemplo:{3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
 * 
 */

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
            int difItensAnt;
            int difItensProx;
            int maiorSeqTamanho = 0;
            int indexMaiorSeq = 0;
            int count = 0;
            int[] maiorSeq;

            // (Des)Comente para escolher o array desejado
            // int[] array = {3, 2};
            // int[] array = {3, 2, 3, 4, 2, 2, 4};
            int[] array = { 3, 2, 3, 4, 2, 2, 4, 10, 12, 14, 16, 0, 8 };


            if (array.Length <= 2)
            {
                ImprimeString(array);
            }
            else
            {
                for (var i = 0; i < array.Length - 2; i++)
                {
                    difItensAnt = array[i + 1] - array[i];
                    difItensProx = array[i + 2] - array[i + 1];

                    if (difItensProx == difItensAnt)
                    {
                        count++;
                        if (count > maiorSeqTamanho)
                        {
                            maiorSeqTamanho = count;
                            indexMaiorSeq = i;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                maiorSeq = new int[maiorSeqTamanho + 2];

                for (var j = 0; j < maiorSeq.Length; j++)
                {
                    maiorSeq[j] = array[indexMaiorSeq - maiorSeqTamanho + j + 1];
                }

                ImprimeString(maiorSeq);

            }

            Console.ReadLine();
        }

        public static void ImprimeString(int[] array)
        {
            Console.Write("{ ");
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" }");
        }
    }
}
