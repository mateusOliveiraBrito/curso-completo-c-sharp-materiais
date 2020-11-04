using LocadoraVeiculoCI.Servicos;

namespace LocadoraVeiculoSI.Servicos
{
    class ImpostoBrasilServico : IImpostoServico
    {
        public double Imposto(double quantia)
        {
            if (quantia <= 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
