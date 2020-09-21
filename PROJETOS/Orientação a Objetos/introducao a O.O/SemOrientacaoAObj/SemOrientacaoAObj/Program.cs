using System;

namespace SolucaoSemOrientacaoObj {
    class Program {
        static void Main(string[] args) {
            double a1, b1, c1;
            double a2, b2, c2;
            double p1, p2;
            double area1, area2;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());

            p1 = (a1 + b1 + c1) / 2;
            p2 = (a2 + b2 + c2) / 2;

            area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

            Console.WriteLine("Área de X = {0}", area1);
            Console.WriteLine("Área de Y = {0}", area2);

            if (area1 > area2) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
