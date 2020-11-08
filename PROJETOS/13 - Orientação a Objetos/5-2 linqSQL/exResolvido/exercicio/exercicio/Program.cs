using exercicio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\produtos.csv";
            List<Produto> produtos = new List<Produto>();

            using (StreamReader str = File.OpenText(path))
            {
                while (!str.EndOfStream)
                {
                    var linha = str.ReadLine().Split(',');
                    produtos.Add(new Produto(linha[0], double.Parse(linha[1])));
                }

                //preço médio
                var media = (from p in produtos select p).Select(x => x.Preco).Average();
                Console.WriteLine("Média dos preços dos produtos: " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                var nomes = (from p in produtos where p.Preco < media select p).OrderByDescending(x => x.Nome).Select(x => x.Nome).ToList();

                Console.WriteLine("NOMES:");
                foreach (var item in nomes)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
