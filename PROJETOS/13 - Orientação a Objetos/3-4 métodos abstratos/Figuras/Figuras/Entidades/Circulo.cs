using Figuras.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras.Entidades
{
    class Circulo : Figura
    {

        public int Raio { get; set; }

        public Circulo(Cor cor, int raio) : base(cor)
        {
            Raio = raio;
        } 


        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
