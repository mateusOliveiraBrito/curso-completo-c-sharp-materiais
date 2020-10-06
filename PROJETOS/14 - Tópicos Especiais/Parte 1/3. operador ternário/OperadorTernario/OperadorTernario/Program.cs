using System;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um preço: ");
            double preco = double.Parse(Console.ReadLine());
            double desconto;

            desconto = (preco < 20) ? (preco * 0.1) : (preco * 0.05);

            Console.WriteLine($"Desconto: {desconto}");
        }
    }
}
