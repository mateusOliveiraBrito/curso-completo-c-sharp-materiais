using System;

namespace LocadoraVeiculoSI.Entidades
{
    class LocacaoDeCarro
    {
        public DateTime DataAlguel { get; private set; }
        public DateTime DataDevolucao { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }

        public LocacaoDeCarro(DateTime dataAlguel, DateTime dataDevolucao, Veiculo veiculo)
        {
            DataAlguel = dataAlguel;
            DataDevolucao = dataDevolucao;
            Veiculo = veiculo;
            Fatura = null; //fatura é nula inicialmente, só será gerada quando for processado o aluguél do carro
        }
    }
}
