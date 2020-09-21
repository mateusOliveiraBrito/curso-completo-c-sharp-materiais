using System;

namespace Exercicio07 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a coordenada X: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y: ");
            double c2 = double.Parse(Console.ReadLine());

            double x = double.Parse(c1.ToString("F1"));
            double y = double.Parse(c2.ToString("F1")); ;

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
        }
    }
}
