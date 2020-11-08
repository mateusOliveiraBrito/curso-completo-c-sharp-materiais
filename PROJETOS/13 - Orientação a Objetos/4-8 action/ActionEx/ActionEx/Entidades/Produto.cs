using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ActionEx.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $@"{Nome}, {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
