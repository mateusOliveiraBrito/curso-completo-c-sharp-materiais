using System;

namespace Funcoes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O maior número é: " + DefineMaior(n1, n2, n3));
        }

        public static int DefineMaior(int n1, int n2, int n3) {
            int maior = 0;

            if (n1 > n2 && n1 > n3) {
                maior = n1;
            } else if (n2 > n3) {
                maior = n2;
            } else {
                maior = n3;
            }
            return maior;
        }
    }
}
