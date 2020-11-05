using ProblemaDiamante.Modelo.Entidades;
using System;

namespace ProblemaDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora() { NumeroDeSerie = 4020 };
            impressora.ProcessamentoDoc("Curriculo");
            impressora.Print("Curriculo");

            Scanner scanner = new Scanner() { NumeroDeSerie = 1098 };
            scanner.ProcessamentoDoc("Email");
            Console.WriteLine(scanner.Scan());
        }
    }
}
