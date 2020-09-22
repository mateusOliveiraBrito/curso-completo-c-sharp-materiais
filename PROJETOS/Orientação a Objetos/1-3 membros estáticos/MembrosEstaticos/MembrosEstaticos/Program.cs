using System;
using System.Globalization;

namespace MembrosEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"CIRCUNFERÊNCIA: {Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}"); 
            Console.WriteLine($"VOLUME: {Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"VALOR DE PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
