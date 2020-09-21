using System;

namespace ProblemaComOrientacaoObj {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine()); 
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.CalculaArea();
            double areaY = y.CalculaArea();

            Console.WriteLine("Área de X = {0}", areaX);
            Console.WriteLine("Área de Y = {0}", areaY);

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            } else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
