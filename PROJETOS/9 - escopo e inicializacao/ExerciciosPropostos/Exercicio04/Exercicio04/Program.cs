using System;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o código de um item: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de um item: ");
            int qnt = int.Parse(Console.ReadLine());
            double valor = 0.0;
            double total = 0.0;

            if (codigo == 1) {
                valor = 4;
            } else if (codigo == 2) {
                valor = 4.5;
            }
            else if (codigo == 3) {
                valor = 5;
            }
            else if (codigo == 4) {
                valor = 2;
            }
            else if (codigo == 5) {
                valor = 1.5;
            }
            else {
                Console.WriteLine("O código inserido não está vinculado a nenhum item!");
            }
            total = qnt * valor;
            Console.WriteLine("O valor total é: R$ {0}", total.ToString("F2"));
        }
    }
}
