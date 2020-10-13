using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entidades.Excessoes
{
    class ContaException : ApplicationException
    {
        public ContaException(string mensagem) : base(mensagem)
        {

        }
    }
}
