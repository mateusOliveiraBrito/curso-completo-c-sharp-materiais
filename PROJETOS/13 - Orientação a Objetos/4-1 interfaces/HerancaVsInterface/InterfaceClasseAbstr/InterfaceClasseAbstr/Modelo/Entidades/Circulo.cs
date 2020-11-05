using InterfaceClasseAbstr.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceClasseAbstr.Modelo.Entidades
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override string ToString()
        {
            return $"Cor do círculo = {Cor} " +
                $"-  Raio = {Raio.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"- Área = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
