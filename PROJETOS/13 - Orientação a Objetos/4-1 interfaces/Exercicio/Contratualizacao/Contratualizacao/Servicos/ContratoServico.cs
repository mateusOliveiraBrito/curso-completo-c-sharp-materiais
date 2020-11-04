using Contratualizacao.Entidades;
using System;

namespace Contratualizacao.Servicos
{
    class ContratoServico
    {
        public IServicoDePagamentoOnline _servicoDePagamentoOnline { get; private set; }

        public ContratoServico(IServicoDePagamentoOnline servicoDePagamentoOnline)
        {
            _servicoDePagamentoOnline = servicoDePagamentoOnline;
        }

        public void ProcessoDeContratualizacao(Contrato contrato, int meses)
        {
            double quotaBasica = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                quotaBasica += _servicoDePagamentoOnline.JuroSimples(quotaBasica, i);
                double totalPrestacoes = quotaBasica + _servicoDePagamentoOnline.TaxaDePagamento(quotaBasica);
                contrato.AdicionaPrestacao(new Prestacao(data, totalPrestacoes));
            }
        }
    }
}
