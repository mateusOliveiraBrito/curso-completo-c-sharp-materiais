using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(t);
        }
    }
}
