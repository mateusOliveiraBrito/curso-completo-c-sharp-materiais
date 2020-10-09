using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecoesPersonalizadas.Entidades.Exceptions
{
    class DominioException : ApplicationException
    {
        public DominioException(string mensagem) : base(mensagem)
        {

        }
    }
}
