using InterfaceClasseAbstr.Modelo.Contratos;
using InterfaceClasseAbstr.Modelo.Entidades;
using InterfaceClasseAbstr.Modelo.Enums;
using System;

namespace InterfaceClasseAbstr
{
    class Program
    {
        static void Main(string[] args)
        {
            IForma c = new Circulo() { Raio = 2, Cor = Cor.Preto };
            IForma r = new Retangulo() { Largura = 2, Altura = 4, Cor = Cor.Branco };

            Console.WriteLine(c);
            Console.WriteLine(r);
        }
    }
}
