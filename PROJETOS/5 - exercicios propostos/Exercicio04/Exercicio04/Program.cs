using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite seu número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor recebido por hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine("NUMBER = {0}", numero);
            Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
