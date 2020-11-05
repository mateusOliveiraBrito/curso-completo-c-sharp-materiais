using InterfaceClasseAbstr.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InterfaceClasseAbstr.Modelo.Entidades
{
    abstract class Forma
    {
        public Cor Cor { get; set; }
        public abstract double Area();
    }
}
