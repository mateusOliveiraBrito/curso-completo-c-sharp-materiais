using ExercicioFixacao.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Informe o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            Funcionario funcionario;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("Terceirizado (s/n)? ");
                bool terceirizado = Console.ReadLine() == "s" ? true : false;
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (terceirizado)
                {
                    Console.Write("Despesa adicional: ");
                    double adicional = double.Parse(Console.ReadLine());

                    funcionario = new FuncionarioTerceirizado(nome, horas, valorPorHora, adicional);
                }
                else
                {
                    funcionario = new Funcionario(nome, horas, valorPorHora);
                }

                funcionarios.Add(funcionario);
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach(var item in funcionarios)
            {
                Console.WriteLine(item);
            }
        }
    }
}
