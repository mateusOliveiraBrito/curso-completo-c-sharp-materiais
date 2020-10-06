using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {funcionario}");

        }
    }
}
