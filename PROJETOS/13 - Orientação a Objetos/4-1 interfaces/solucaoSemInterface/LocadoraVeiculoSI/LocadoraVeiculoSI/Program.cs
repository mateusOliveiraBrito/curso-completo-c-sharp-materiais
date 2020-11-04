using LocadoraVeiculoSI.Entidades;
using LocadoraVeiculoSI.Servicos;
using System;
using System.Globalization;

namespace LocadoraVeiculoSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de aluguel (dd/MM/yyyy hh:mm): ");
            DateTime dataAluguel = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de devolução (dd/MM/yyyy hh:mm): ");
            DateTime dataDevolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre o valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o valor por dia: ");
            double valorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            LocacaoDeCarro aluguelCarro = new LocacaoDeCarro(dataAluguel, dataDevolucao, new Veiculo(modelo));

            LocacaoServico locacaoServico = new LocacaoServico(valorHora, valorDia);

            locacaoServico.ProcessoLocacao(aluguelCarro);

            Console.WriteLine();
            Console.WriteLine("FATURA:");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
