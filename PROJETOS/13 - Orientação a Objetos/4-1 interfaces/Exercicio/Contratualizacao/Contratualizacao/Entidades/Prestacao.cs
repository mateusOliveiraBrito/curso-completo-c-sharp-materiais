using System;
using System.Globalization;

namespace Contratualizacao.Entidades
{
    class Prestacao
    {
        public DateTime DataVencimento { get; private set; }
        public double Valor { get; private set; }

        public Prestacao(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{DataVencimento.ToString("dd/MM/yyyy")} - {Valor.ToString("F2", CultureInfo.InvariantCulture)}"; ;
        }
    }
}
