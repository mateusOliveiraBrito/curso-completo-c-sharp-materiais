using ExercicioFixacaoProduto.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto;

            Console.Write("Quantos produtos serão inseridos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto #{i}");
                Console.Write("Produto comum, usado ou importado (c/u/i)? ");
                string opc = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (opc)
                {
                    case "c":
                        produto = new Produto(nome, preco);
                        produtos.Add(produto);
                        Console.WriteLine();
                        break;

                    case "i":
                        Console.Write("Taxa alfandegária: ");
                        double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        produto = new ProdutoImportado(nome, preco, taxa);
                        produtos.Add(produto);
                        Console.WriteLine();
                        break;

                    case "u":
                        Console.Write("Data de fabricação (DD/MM/AAAA): ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        produto = new ProdutoUsado(nome, preco, data);
                        produtos.Add(produto);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            foreach(var item in produtos)
            {
                Console.WriteLine(item.EtiquetaDePreco());
            }
        }
    }
}
