using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Imposto.Entidades
{
    class PessoaFisica : Pessoa
    {

        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
            : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Imposto()
        {

            double porcentagem = 0.0;
            double descontoSaude = 0.0;

            if (RendaAnual < 20000.0)
            {
                porcentagem = 15.0 / 100;
            }
            else if (RendaAnual >= 20000.0)
            {
                porcentagem = 25.0 / 100;
            }

            if (GastosComSaude >= 0.0)
            {
                descontoSaude = (50.0 / 100) * GastosComSaude;
            }

            return RendaAnual * porcentagem - descontoSaude;
        }

        public sealed override string ToString()
        {
            return $"{Nome}: $ {Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
