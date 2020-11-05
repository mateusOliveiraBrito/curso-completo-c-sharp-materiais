using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceClasseAbstr.Modelo.Entidades
{
    class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double Area()
        {
            return Altura * Largura;
        }

        public override string ToString()
        {
            return $"Cor do Retangulo: {Cor}" +
                $"-Altura: {Altura.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"-Largura: {Largura.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"-Área: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
