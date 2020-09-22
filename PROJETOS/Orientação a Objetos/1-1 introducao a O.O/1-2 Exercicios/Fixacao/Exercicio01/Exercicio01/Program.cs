using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {retangulo.Area()}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro()}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal()}");
        }
    }
}
