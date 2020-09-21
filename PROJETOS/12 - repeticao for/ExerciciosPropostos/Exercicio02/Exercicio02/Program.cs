using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int ins = 0, outs = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    ins++;
                }
                else {
                    outs++;
                }
            }

            Console.WriteLine($"{ins} in");
            Console.WriteLine($"{outs} out");
        }
    }
}
