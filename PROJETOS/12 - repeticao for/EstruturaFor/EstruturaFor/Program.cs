using System;

namespace EstruturaFor {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int qnt = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < qnt; i++) {
                int n = int.Parse(Console.ReadLine());
                soma += n;
                Console.WriteLine($"Valor #{i}: " + n);
            }

            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
