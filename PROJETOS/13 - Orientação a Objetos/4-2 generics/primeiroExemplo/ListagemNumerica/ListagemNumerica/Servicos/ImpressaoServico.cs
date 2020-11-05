using ListagemNumerica.Contratos;
using System;
using System.Collections.Generic;

namespace ListagemNumerica.Servicos
{
    class ImpressaoServico : IImpressaoServico
    {
        List<object> Objetos = new List<object>();

        public void AddObjeto(object n)
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

        public object Primeiro()
        {
            return Objetos[0];
        }
    }
}
