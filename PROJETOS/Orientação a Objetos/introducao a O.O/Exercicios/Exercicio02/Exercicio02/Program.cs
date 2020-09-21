using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio: {0}", media);
        }
    }
}
