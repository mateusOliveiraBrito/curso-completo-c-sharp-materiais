using System;
using System.Globalization;

namespace Exercicio06 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor A: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um valor B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um valor C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double a = double.Parse(A.ToString("F1"));
            double b = double.Parse(B.ToString("F1"));
            double c = double.Parse(C.ToString("F1"));

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * (Math.Pow(c, 2));
            double trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("TRIÂNGULO: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
