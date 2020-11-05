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

            Console.WriteLine();

            Scanner scanner = new Scanner() { NumeroDeSerie = 1098 };
            scanner.ProcessamentoDoc("Email");
            Console.WriteLine(scanner.Scan());

            Console.WriteLine();

            MultiProcessador multi = new MultiProcessador() { NumeroDeSerie = 3506 };
            multi.ProcessamentoDoc("Diploma");
            multi.Print("Diploma");
            Console.WriteLine(multi.Scan()); ;
        }
    }
}
