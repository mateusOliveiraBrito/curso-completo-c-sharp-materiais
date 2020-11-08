using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // definindo a fonte de dados
            int[] numeros = new int[] { 2, 3, 4, 5 };

            // definindo a expressão de consulta
            List<int> result = numeros.Where(p => p % 2 == 0).Select(x => x * 10).ToList(); //where filtra os itens da lista e o select aplica uma função a cada item da lista

            // executando a consulta
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
