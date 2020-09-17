using System;

namespace OperadoresAritmeticos {
    class Program {
        static void Main(string[] args) {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; //ou 10.0 no lugar do casting

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // ou (b * b) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);            
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("Delta é: {0}", delta);
            Console.WriteLine("Uma raíz de x é: {0}", x1);
            Console.WriteLine("Uma raiz de x é: {0}", x2);
        }
    }
}
