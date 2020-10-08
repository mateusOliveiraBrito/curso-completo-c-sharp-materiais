using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Imposto.Entidades
{
    class PessoaJuridica : Pessoa
    {

        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            double porcentagem = 0.0;

            if (NumeroFuncionarios <= 10)
            {
                porcentagem = 16.0 / 100;
            }
            else
            {
                porcentagem = 14.0 / 100;
            }

            return RendaAnual * porcentagem;
        }

        public sealed override string ToString()
        {
            return $"{Nome}: $ {Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
