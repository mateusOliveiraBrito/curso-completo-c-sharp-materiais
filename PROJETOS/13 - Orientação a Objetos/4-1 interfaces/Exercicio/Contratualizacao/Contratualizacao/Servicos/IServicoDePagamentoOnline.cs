namespace Contratualizacao.Servicos
{
    interface IServicoDePagamentoOnline
    {
        double TaxaDePagamento(double valor);
        double JuroSimples(double valor, int meses);
    }
}
