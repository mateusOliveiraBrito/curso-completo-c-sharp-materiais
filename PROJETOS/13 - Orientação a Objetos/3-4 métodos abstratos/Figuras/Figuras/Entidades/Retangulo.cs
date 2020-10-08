using Figuras.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras.Entidades
{
    class Retangulo : Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Retangulo(Cor cor, int rBase, int rAltura) : base(cor)
        {
            Base = rBase;
            Altura = rAltura;
        }

        public override double Area()
        {
            return Base * Altura;
        }
    }
}
