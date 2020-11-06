using System;
using System.Collections.Generic;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo com HashSet
            HashSet<string> conjuntoHSet = new HashSet<string>();

            conjuntoHSet.Add("TV");
            conjuntoHSet.Add("Notebook");
            conjuntoHSet.Add("Tablet");
            conjuntoHSet.Add("Smartphone");

            // Verifica se no conjunto existe o objeto do parâmetro
            Console.WriteLine(conjuntoHSet.Contains("Notebook"));

            // Utiliza-se o foreach porque não é possível utilizar o for, pois os elementos de um conjunto ão têm posição
            foreach (string item in conjuntoHSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
