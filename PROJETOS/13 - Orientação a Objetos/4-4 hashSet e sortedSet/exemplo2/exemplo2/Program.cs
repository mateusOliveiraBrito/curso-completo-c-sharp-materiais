using System;
using System.Collections.Generic;
using System.Linq;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando o SortedSet
            SortedSet<int> conjunto = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> conjunto2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            SortedSet<int> resultadoU = new SortedSet<int>(conjunto); //esse construtor permite já iniciar o conjunto com elementos contidos no conjunto informado no parâmetro
            SortedSet<int> resultadoI = new SortedSet<int>(conjunto); //esse construtor permite já iniciar o conjunto com elementos contidos no conjunto informado no parâmetro
            SortedSet<int> resultadoD = new SortedSet<int>(conjunto); //esse construtor permite já iniciar o conjunto com elementos contidos no conjunto informado no parâmetro

            // União dos conjuntos
            resultadoU.UnionWith(conjunto2);
            ImprimeColecao(resultadoU);

            // Intersecção
            resultadoI.IntersectWith(conjunto2);
            ImprimeColecao(resultadoI);

            // Diferença
            resultadoD.ExceptWith(conjunto2);
            ImprimeColecao(resultadoD);
        }

        public static void ImprimeColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
