using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b) {
                if (a % b == 0) {
                    Console.WriteLine($"{a} é múltiplo de {b}");
                }
                else {
                    Console.WriteLine($"{a} não é múltiplo de {b}");
                }
            }
            else {
                if (b % a == 0) {
                    Console.WriteLine($"{b} é múltiplo de {a}");
                }
                else {
                    Console.WriteLine($"{b} não é múltiplo de {a}");
                }
            }
        }
    }
}
