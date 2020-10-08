using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacao.Entidades
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional)
        : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public sealed override double Pagamento()
        {
            return base.Pagamento() + ((110 / 100) * DespesaAdicional);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" - $ ");
            sb.Append(Pagamento().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
