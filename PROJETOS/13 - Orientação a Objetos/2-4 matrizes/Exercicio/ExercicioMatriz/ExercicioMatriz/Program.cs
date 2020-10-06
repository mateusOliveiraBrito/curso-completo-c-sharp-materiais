using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("PREENCHA A MATRIZ:");
            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"-LINHA {i}:");
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Informe o valor da coluna {j} da linha {i}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
            }

            Console.WriteLine();

            ImprimeMatriz(matriz);

            Console.Write("Informe um elemento contido na matriz: ");
            int elemento = int.Parse(Console.ReadLine());
            Console.WriteLine();

            VerificaElemento(matriz, elemento);
        }

        public static void ImprimeMatriz(int[,] matriz)
        {
            Console.WriteLine("MATRIZ:");
            Console.WriteLine();

            int l = matriz.GetLength(0);
            int c = matriz.GetLength(1);

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matriz[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void VerificaElemento(int[,] matriz, int elemento)
        {
            int l = matriz.GetLength(0);
            int c = matriz.GetLength(1);

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] == elemento)
                    {
                        Console.WriteLine($"Posição: {i},{j}");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"-Esquerda: {matriz[i, (j - 1)]}");
                        }

                        if (j + 1 < c)
                        {
                            Console.WriteLine($"-Direita: {matriz[i, (j + 1)]}");
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"-Cima: {matriz[(i - 1), j]}");
                        }

                        if (i + 1 < l)
                        {
                            Console.WriteLine($"-Baixo: {matriz[(i + 1), j]}");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
