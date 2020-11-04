using System.Globalization;

namespace LocadoraVeiculoSI.Entidades
{
    class Fatura
    {
        public double PagamentoMinimo { get; private set; }
        public double Imposto { get; private set; }

        public Fatura(double pagamentoMinimo, double imposto)
        {
            PagamentoMinimo = pagamentoMinimo;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoMinimo + Imposto; }
        }

        public override string ToString()
        {
            return $"Pagamento mínimo: $ {PagamentoMinimo.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nImposto: $ {Imposto.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nPagamento Total: $ {PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
