namespace ListagemNumerica.Contratos
{
    interface IImpressaoServico
    {
        void AddObjeto(object n);
        object Primeiro();
        void Imprime();
    }
}
