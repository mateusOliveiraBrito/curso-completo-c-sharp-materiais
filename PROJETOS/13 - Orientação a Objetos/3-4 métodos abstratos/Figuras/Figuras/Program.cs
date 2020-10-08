using Figuras.Entidades;
using Figuras.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            Figura figura;
            List<Figura> figuras = new List<Figura>();

            Console.Write("Quantas figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da Figura #{i}: ");
                Console.Write("Retângulo ou círculo (r/c)? ");
                string opc = Console.ReadLine();
                Console.Write("Informe a cor: ");
                string cor = Console.ReadLine();

                if (opc == "c")
                {
                    Console.Write("Informe o valor do raio: ");
                    int raio = int.Parse(Console.ReadLine());
                    figura = new Circulo(Enum.Parse<Cor>(cor), raio);
                    figuras.Add(figura);
                }
                else if (opc == "r")
                {
                    Console.Write("Informe o valor da base: ");
                    int baser = int.Parse(Console.ReadLine());
                    Console.Write("Informe o valor da altura: ");
                    int altura = int.Parse(Console.ReadLine());
                    figura = new Retangulo(Enum.Parse<Cor>(cor), baser, altura);
                    figuras.Add(figura);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("ÁREA DAS FIGURAS:");
            foreach(var item in figuras)
            {
                Console.WriteLine(item.Area());
            }
        }
    }
}
