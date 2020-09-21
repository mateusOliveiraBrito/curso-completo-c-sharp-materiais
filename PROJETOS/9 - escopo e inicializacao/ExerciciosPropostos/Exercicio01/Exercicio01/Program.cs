using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0) {
                Console.WriteLine($"{n} É negativo!");
            }
            else {
                Console.WriteLine($"{n} NÃO é negativo!");
            }
        }
    }
}
