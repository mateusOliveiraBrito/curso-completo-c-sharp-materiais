using InterfaceClasseAbstr.Modelo.Entidades;
using InterfaceClasseAbstr.Modelo.Enums;
using System;

namespace InterfaceClasseAbstr
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma c = new Circulo() { Raio = 2, Cor = Cor.Preto };
            Forma r = new Retangulo() { Largura = 2, Altura = 4, Cor = Cor.Branco };

            Console.WriteLine(c);
            Console.WriteLine(r);
        }
    }
}
