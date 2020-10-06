using System;
using System.Globalization;

namespace Vetores01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de dados que serão inseridos: ");
            int n = int.Parse(Console.ReadLine());
            double alturasSoma = 0.0, media;

            double[] alturas = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite a {i + 1}° altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                alturasSoma += alturas[i];
            }

            media = alturasSoma / alturas.Length;

            Console.WriteLine($"Média: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
