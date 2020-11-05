using ListagemNumerica.Contratos;
using System;
using System.Collections.Generic;

namespace ListagemNumerica.Servicos
{
    class ImpressaoServico<T> : IImpressaoServico
    {
        List<T> Objetos = new List<T>();

        public void AddObjeto(T n)
        {
            Objetos.Add(n);
        }

        public void Imprime()
        {
            int posicao = 0;
            string saida = "[";
            foreach (var item in Objetos)
            {
                saida += item;

                if (posicao != Objetos.Count - 1)
                {
                    saida += ", ";
                }

                posicao++;
            }

            saida += "]";

            Console.WriteLine(saida);
        }

        public T Primeiro()
        {
            return Objetos[0];
        }
    }
}
