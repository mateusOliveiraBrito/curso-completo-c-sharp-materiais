using Imposto.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa;
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Informe o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuinte #{i}");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                string opc = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Dispesa anual: ");
                double dispesaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == "f")
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa = new PessoaFisica(nome, dispesaAnual, gastosComSaude);
                    pessoas.Add(pessoa);
                }
                else if (opc == "j")
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa = new PessoaJuridica(nome, dispesaAnual, numeroFuncionarios);
                    pessoas.Add(pessoa);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("CONTRIBUINTES DE IMPOSTO:");
            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            double soma = 0.0;

            foreach (var item in pessoas)
            {
                soma += item.Imposto();
            }

            Console.Write($"TOTAL DE IMPOSTO: $ {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
