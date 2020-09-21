using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine($"{n} é PAR!");
            }
            else {
                Console.WriteLine($"{n} é ÍMPAR!");
            }
        }
    }
}
