using Exercicio.Entidades.Excessoes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() { }

        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia > Saldo)
            {
                throw new ContaException("A conta não possui saldo suficiente para saque!");
            }

            if (quantia >= LimiteSaque)
            {
                throw new ContaException("O valor solicitado é superior ao limite de saque permitido!");
            }

            Saldo -= quantia;
        }

        public override string ToString()
        {
            return $"R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
