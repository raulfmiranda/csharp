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
            int N2 = N * N;
            int[,] matriz = new int[N, N];

            // Gerando Matriz A
            Console.WriteLine("     - Matriz A -");
            int[,] vetor = CriaVetorA(N);
            int count = 1;

            for (int i = 0; i < N2; i++)
            {
                matriz[vetor[0, i], vetor[1, i]] = count++;
            }

            ImprimeMatriz(matriz);

            // Gerando Matriz B
            Console.WriteLine("\n\n     - Matriz B -");

            matriz = MatrizA2B(matriz);
            ImprimeMatriz(matriz);

            // Gerando Matriz C
            Console.WriteLine("\n\n     - Matriz C -");
            vetor = CriaVetorC(N);
            count = 1;

            for (int i = 0; i < N2; i++)
            {
                matriz[vetor[0, i], vetor[1, i]] = count++;
            }

            ImprimeMatriz(matriz);
            Console.ReadLine();
        }

        public static int[,] CriaVetorA(int N)
        {
            int N2 = N * N;
            int[,] vA = new int[2, N2];

            // gera linhas do vA
            int count = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = N - 1; j >= i; j--)
                {
                    vA[0, count++] = j;
                }
            }
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    vA[0, count++] = j;
                }
            }

            // gera colunas do vA
            count = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = i; j < N; j++)
                {
                    vA[1, count++] = j;
                }
            }
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    vA[1, count++] = j;
                }
            }

            return vA;
        }

        public static int[,] CriaVetorC(int N)
        {
            int N2 = N * N;
            int[,] vC = new int[2, N2];
            int i = 0, j = 0, k = 0, count = 0;

            while (count < N2)
            {
                for (; i < N - k; i++)
                {
                    vC[0, count] = i;
                    vC[1, count] = j;
                    count++;
                    if (count == N2) return vC;
                }
                i--;
                j++;
                for (; j < N - k; j++)
                {
                    vC[0, count] = i;
                    vC[1, count] = j;
                    count++;
                    if (count == N2) return vC;
                }
                i--;
                for (j--; i >= 0 + k; i--)
                {
                    vC[0, count] = i;
                    vC[1, count] = j;
                    count++;
                    if (count == N2) return vC;
                }
                j--;
                k++;
                for (i++; j >= 0 + k; j--)
                {
                    vC[0, count] = i;
                    vC[1, count] = j;
                    count++;

                    if (count == N2) return vC;
                }
                i++;
                j++;
            }
            return vC;
        }

        public static int[,] MatrizA2B(int[,] matrizA)
        {
            int N = matrizA.GetLength(0);
            int[,] matrizB = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrizB[i, j] = matrizA[N - (1 + j), i];
                }
            }

            return matrizB;
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
