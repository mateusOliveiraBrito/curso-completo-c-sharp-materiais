using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor entre 1 e 1000: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 1000) {

                for(int i = 1; i <= n; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            } else {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}
