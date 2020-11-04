using Contratualizacao.Entidades;
using Contratualizacao.Servicos;
using System;
using System.Globalization;

namespace Contratualizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRE COM AS INFORMAÇÕES DE CONTRATO: ");
            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de prestações: ");
            int numeroPrestacoes = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numeroContrato, data, valor);
            ContratoServico contratoServico = new ContratoServico(new PayPalServico());
            contratoServico.ProcessoDeContratualizacao(contrato, numeroPrestacoes);

            Console.WriteLine();
            Console.WriteLine("PRESTAÇÕES: ");
            foreach (Prestacao prestacao in contrato.Prestacoes)
            {
                Console.WriteLine(prestacao);
            }
        }
    }
}
