using System;

namespace EscopoEInicializacao {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());
            double desconto;
            if (preco > 100) {
                desconto = preco * 0.1;
            }
            else {
                desconto = 0.0;
            }

            Console.WriteLine(desconto);
        }
    }
}
