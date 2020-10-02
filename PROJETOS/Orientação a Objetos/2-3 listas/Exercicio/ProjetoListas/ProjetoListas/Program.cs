using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int id = 0;
            string nome;
            double salario;

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("Digite o id do funcionário: ");
                id = int.Parse(Console.ReadLine());

                if (VerificaFuncionarioExistente(id, funcionarios))
                {
                    Console.WriteLine("Um funcionário com esse Id já foi inserido, tente novamente!");
                    Console.WriteLine();
                    i--;
                    continue;
                }
                else
                {
                    Console.Write("Digite o nome do funcionário: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite o salário do funcionário: ");
                    salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionarios.Add(new Funcionario(id, nome, salario));
                    Console.WriteLine();
                }
            }

            Console.Write("Insira o Id do funcionário que terá aumento salarial: ");
            id = int.Parse(Console.ReadLine());

            if (VerificaFuncionarioExistente(id, funcionarios))
            {
                Console.Write("Digite a porcentagem do aumento salarial: ");
                double porcentagem = double.Parse(Console.ReadLine());
                Funcionario funcionario = funcionarios.Find(x => x.Id == id);
                funcionario.AumentaSalario(porcentagem);

                Console.WriteLine();
                Console.WriteLine("Lista de funcionários atualizada:");

                ListaFuncionarios(funcionarios);
            } else
            {
                Console.WriteLine("Esse funcionário não existe!");
                Console.WriteLine();
            }
        }

        public static bool VerificaFuncionarioExistente(int id, List<Funcionario> funcionarios)
        {
            Funcionario funcionarioExistente = funcionarios.Find(x => x.Id == id);
            if (funcionarioExistente != null)
                return true;
            else
                return false;
        }

        public static void ListaFuncionarios(List<Funcionario> funcionarios)
        {
            foreach(var item in funcionarios)
            {
                Console.WriteLine(item);
            }
        }
    }
}
