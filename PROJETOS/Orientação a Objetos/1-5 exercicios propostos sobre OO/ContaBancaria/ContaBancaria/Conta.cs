using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ContaBancaria {
    class Conta {
        /* o modificador de acesso private antes do set significa que ele nao poderá ser alterado
         nesse caso de Numero, se dentro da classe ContaBancaria houvesse um método para alterar esse valor, ele seria alterado,
         no entanto não existe, por isso ele não poderá ser alterado em outras classes do programa*/
        public int Numero { get; private set; }
        public string Titular { get; set; }
        /* o modificador de acesso private indica que Saldo não poderá ser acessado por outra classe e que suas modificações
         só poderão ocorrer através dos métodos de saque e depósito. */
        public double Saldo { get; private set; }

        public Conta(int numero, string nome) {
            this.Numero = numero;
            this.Titular = nome;
            this.Saldo = 0.0;
        }

        public Conta(int numero, string nome, double saldoInicial) : this(numero, nome) {
            Deposito(saldoInicial);
        }

        public void Deposito(double valor) {
            this.Saldo += valor;
        }

        public void Saque(double valor) {
            this.Saldo -= (valor + 5);
        }

        public override string ToString() {
            return $"Conta: {this.Numero}, Titular: {this.Titular}, Saldo: $ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
