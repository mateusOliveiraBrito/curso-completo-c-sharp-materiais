using Exercicio.Entidades;
using Exercicio.Entidades.Excessoes;
using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da conta:");
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Informe o saldo inicial da conta: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o limite do saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(numero, titular, saldo, limite);

            Console.WriteLine();

            Console.Write("Informe um valor para saque: ");
            double valor = double.Parse(Console.ReadLine());

            try
            {
                conta.Saque(valor);
                Console.Write($"Novo saldo: {conta.ToString()}");
            }
            catch (ContaException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
