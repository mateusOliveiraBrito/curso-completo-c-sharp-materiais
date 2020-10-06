using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Vetores02Objetos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe a quantidade de produtos que serão inseridos: ");
            int qnt = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qnt]; 

            for (int i = 0; i < qnt; i++) {
                Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto(nome, preco);
            }
            Console.WriteLine($"Média de preços = $ {CalculaMedia(produtos).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static double CalculaMedia(Produto[] produtos) {
            double soma = 0.0, media = 0.0;
            for (int i = 0; i < produtos.Length; i++) {
                soma += produtos[i].Preco;
            }

            media = soma / produtos.Length;
            return media;
        }
    }
}
