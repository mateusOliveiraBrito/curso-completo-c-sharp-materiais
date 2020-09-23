using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {
            int numero;
            string titular;
            char opcao;
            double valor;
            Conta conta = null;

            Console.Write("Entre com o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial: (s/n): ");
            opcao = char.Parse(Console.ReadLine());

            if (opcao == 's') {
                Console.Write("Entre com o depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, valor);
                Console.WriteLine("");
            }
            else if (opcao == 'n'){
                conta = new Conta(numero, titular);
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("Opção inválida");
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine("");

            Console.Write("Entre com um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine("");

            Console.Write("Entre com um valor para o saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
