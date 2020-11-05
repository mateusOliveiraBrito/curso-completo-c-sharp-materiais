using InterfaceClasseAbstr.Modelo.Contratos;
using InterfaceClasseAbstr.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InterfaceClasseAbstr.Modelo.Entidades
{
    abstract class Forma : IForma
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
