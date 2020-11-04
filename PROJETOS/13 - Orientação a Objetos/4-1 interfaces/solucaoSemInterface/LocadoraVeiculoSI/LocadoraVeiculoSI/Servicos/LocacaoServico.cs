using LocadoraVeiculoSI.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculoSI.Servicos
{
    class LocacaoServico
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ImpostoBrasilServico _ImpostoBrasilServico = new ImpostoBrasilServico();

        public LocacaoServico(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessoLocacao(LocacaoDeCarro locacaoDeCarro)
        {
            //calcula a duração do aluguel com base no instante de locação e o instante de devolução
            TimeSpan duracao = locacaoDeCarro.DataDevolucao.Subtract(locacaoDeCarro.DataAlguel);

            double PagamentoMinimo = 0.0;
            if (duracao.TotalHours <= 12)
            {
                PagamentoMinimo = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                PagamentoMinimo = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _ImpostoBrasilServico.Imposto(PagamentoMinimo);

            locacaoDeCarro.Fatura = new Fatura(PagamentoMinimo, imposto);
        }
    }
}
