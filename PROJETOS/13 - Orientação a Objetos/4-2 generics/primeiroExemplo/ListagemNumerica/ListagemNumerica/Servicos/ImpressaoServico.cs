using ListagemNumerica.Contratos;
using System;
using System.Collections.Generic;

namespace ListagemNumerica.Servicos
{
    class ImpressaoServico : IImpressaoServico
    {
        List<int> numeros = new List<int>();

        public void AddNumero(int n)
        {
            numeros.Add(n);
        }

        public void Imprime()
        {
            int posicao = 0;
            string saida = "[";
            foreach (int item in numeros)
            {
                saida += item;

                if (posicao != numeros.Count - 1)
                {
                    saida += ", ";
                }

                posicao++;
            }

            saida += "]";

            Console.WriteLine(saida);
        }

        public int Primeiro()
        {
            return numeros[0];
        }
    }
}
