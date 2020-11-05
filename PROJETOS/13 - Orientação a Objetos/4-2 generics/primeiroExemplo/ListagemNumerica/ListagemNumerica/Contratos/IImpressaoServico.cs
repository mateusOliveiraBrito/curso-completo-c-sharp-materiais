using System;
using System.Collections.Generic;
using System.Text;

namespace ListagemNumerica.Contratos
{
    interface IImpressaoServico
    {
        void AddNumero(int n);
        int Primeiro();
        void Imprime();
    }
}
