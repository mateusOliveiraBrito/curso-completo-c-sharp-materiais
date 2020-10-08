using Figuras.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figuras.Entidades
{
    abstract class Figura
    {
        public Cor Cor { get; set; }

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
