using System;
using System.Collections.Generic;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = LerDados();

            ImprimeMatriz(matriz);
            ImprimeDiagonal(matriz);
            ContaNegativos(matriz);
        }

        public static int[,] LerDados()
        {
            Console.Write("Informe um número de ordem para a matriz: ");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}° LINHA:");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i + 1}° coluna: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
            }

            return matriz;

        }

        public static void ImprimeMatriz(int[,] matriz)
        {
            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void ImprimeDiagonal(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            int[] diagonal = new int[3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        diagonal[i] = matriz[i, j];
                    }
                }
            }

            Console.Write("Diagonal principal: ");

            for (int i = 0; i < diagonal.Length; i++)
            {
                Console.Write(diagonal[i] + " ");
            }
            Console.WriteLine();
        }

        public static void ContaNegativos(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            List<int> negativos = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativos.Add(matriz[i, j]);
                    }
                }
            }
            Console.Write($"Números negativos: {negativos.Count}");
            Console.WriteLine();
        }
    }
}
