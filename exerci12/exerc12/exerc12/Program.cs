/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 12  [15/05/2017]
 * 
 * Escreva um programa que preencha uma matriz de tamanho (N, N) conforme exemplos (for N=4):
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 4;
            int[,] matriz = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    matriz[i, j] = i + j;
                }
            }

            ImprimeMatriz(matriz);
            Console.ReadLine();
        }

        public static int[,] CriaMatrizA(int N)
        {

        }

        public static void ImprimeMatriz(int[,] matriz)
        {
            int N = (int)Math.Sqrt(matriz.Length); 

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 10)
                    {
                        Console.Write("  " + matriz[i, j] + "  ");
                    }
                    else if (matriz[i, j] >= 10 && matriz[i, j] < 100)
                    {
                        Console.Write("  " + matriz[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  " + matriz[i, j]);
                    }
                }
            }
        }
    }
}
