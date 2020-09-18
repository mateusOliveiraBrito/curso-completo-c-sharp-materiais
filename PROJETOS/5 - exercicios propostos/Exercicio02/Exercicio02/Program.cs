using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio de um círculo:");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * (Math.Pow(raio, 2));

            Console.WriteLine("A = {0}", area.ToString("F4"));
        }
    }
}
