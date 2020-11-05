using ProblemaDiamante.Modelo.Contratos;
using System;

namespace ProblemaDiamante.Modelo.Entidades
{
    class Scanner : Dispositivo, IScanner
    {
        public override void ProcessamentoDoc(string documento)
        {
            Console.WriteLine($"Scanner processando: {documento}");
        }

        public string Scan()
        {
            return "Resultado do escaneamento do Scanner";
        }
    }
}
