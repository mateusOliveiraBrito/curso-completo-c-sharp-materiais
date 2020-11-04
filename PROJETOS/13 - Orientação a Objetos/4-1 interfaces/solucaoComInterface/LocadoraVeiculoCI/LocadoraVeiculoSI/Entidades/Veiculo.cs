namespace LocadoraVeiculoSI.Entidades
{
    class Veiculo
    {
        public string Modelo { get; private set; }

        public Veiculo(string model)
        {
            model = model;
        }
    }
}
