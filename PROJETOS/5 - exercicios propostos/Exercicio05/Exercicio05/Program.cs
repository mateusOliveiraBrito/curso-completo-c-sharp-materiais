using System;
using System.Globalization;

namespace Exercicio05 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o código da 1° peça: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças : ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário de cada peça: ");
            double valorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o código da 2° peça: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças : ");
            int quantidade2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário de cada peça: ");
            double valorUnitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = (quantidade * valorUnitario) + (quantidade2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
