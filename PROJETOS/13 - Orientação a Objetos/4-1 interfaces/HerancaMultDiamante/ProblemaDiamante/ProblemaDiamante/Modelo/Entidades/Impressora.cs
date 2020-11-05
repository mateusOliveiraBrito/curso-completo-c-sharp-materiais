using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDiamante.Modelo.Entidades
{
    class Impressora : Dispositivo
    {
        public override void ProcessamentoDoc(string documento)
        {
            Console.WriteLine($"Impressora processando: {documento}");
        }

        public void Print(string documento)
        {
            Console.WriteLine($"Impressão da Impressora: {documento}");
        }
    }
}
