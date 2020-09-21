using System;

namespace Exercicio08 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            double imposto = 0.0;

            if (salario >= 0 && salario <= 2000) {
                Console.WriteLine("Isento");
                imposto = 0.0;
            } else if (salario >= 2000.01 && salario <= 3000) {
                imposto = salario * 0.08;
            } else if (salario >= 3000.01 && salario <= 4500) {
                imposto = salario * 0.018;
            } else if (salario > 4500) {
                imposto = salario * 0.028;
            }

            Console.WriteLine(imposto);
        }
    }
}
