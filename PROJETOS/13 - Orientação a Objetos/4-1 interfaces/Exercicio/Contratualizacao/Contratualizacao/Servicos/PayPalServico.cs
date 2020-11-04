using System;
using System.Collections.Generic;
using System.Text;

namespace Contratualizacao.Servicos
{
    class PayPalServico : IServicoDePagamentoOnline
    {
        private const double PorcentagemTaxaDePagamento = 0.02;
        private const double PorcentagemJuroSimples = 0.01;

        public double JuroSimples(double valor, int meses)
        {
            return valor * PorcentagemTaxaDePagamento * meses;
        }

        public double TaxaDePagamento(double valor)
        {
            return valor * PorcentagemJuroSimples;
        }
    }
}
