using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FuncEx.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
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
