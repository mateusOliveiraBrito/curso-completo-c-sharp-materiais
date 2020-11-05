using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDiamante.Modelo.Entidades
{
    abstract class Dispositivo
    {
        public int NumeroDeSerie { get; set; }

        public abstract void ProcessamentoDoc(string documento);
    }
}
