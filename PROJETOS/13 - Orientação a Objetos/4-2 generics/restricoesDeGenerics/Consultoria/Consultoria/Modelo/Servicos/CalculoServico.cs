using Consultoria.Modelo.Contratos;
using System;
using System.Collections.Generic;

namespace Consultoria.Modelo.Servicos
{
    class CalculoServico : ICalculoServico
    {

        public T MaiorSalario<T>(List<T> lista) where T : IComparable
        {
            if (lista.Count == 0)
            {
                throw new Exception("A lista de dados de produto não pode ser vazia!");
            }

            T max = lista[0];

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CompareTo(max) > 0)
                {
                    max = lista[i];
                }
            }

            return max;
        }
    }
}
