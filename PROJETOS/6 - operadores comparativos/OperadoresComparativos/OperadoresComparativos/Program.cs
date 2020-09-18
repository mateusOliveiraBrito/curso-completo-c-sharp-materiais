using System;

namespace OperadoresComparativos {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            bool c1 = a > 10;
            bool c2 = a >= 10;
            bool c3 = a < 10;
            bool c4 = a <= 10;
            bool c5 = a == 10;
            bool c6 = a != 10;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}
