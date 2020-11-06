using System;
using System.Collections.Generic;

namespace Consultoria.Modelo.Contratos
{
    interface ICalculoServico
    {
        T MaiorSalario<T>(List<T> lista) where T : IComparable;
    }
}
