namespace LocadoraVeiculoSI.Servicos
{
    class ImpostoBrasilServico
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
