using Consultoria.Modelo.Entidades;
using Consultoria.Modelo.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Consultoria
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoServico _calculoServico = new CalculoServico();
            List<Produto> produtos = new List<Produto>();

            Console.Write("Informe a quantidade de produtos para inserção: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(',');
                double salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);

                produtos.Add(new Produto(vetor[0], salario));
                vetor = null;
            }

            Console.WriteLine();
            Console.WriteLine("Max: ");
            Console.WriteLine(_calculoServico.MaiorSalario(produtos));
        }
    }
}
