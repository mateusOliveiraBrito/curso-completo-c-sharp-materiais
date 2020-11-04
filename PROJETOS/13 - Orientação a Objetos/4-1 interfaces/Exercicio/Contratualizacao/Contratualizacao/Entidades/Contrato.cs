using System;
using System.Collections.Generic;

namespace Contratualizacao.Entidades
{
    class Contrato
    {
        public int Numero { get; private set; }
        public DateTime Data { get; private set; }
        public Double ValorTotal { get; private set; }
        public List<Prestacao> Prestacoes { get; private set; }

        public Contrato(int numero, DateTime date, double valorTotal)
        {
            Numero = numero;
            Data = date;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacao>();
        }

        public void AdicionaPrestacao(Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }
    }
}
