using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LinqLambda.Entidades
{
    class Produto
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public double Preco { get;  set; }
        public Categoria Categoria { get;  set; }

        public Produto(int id, string nome, double preco, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $@"{Id}, {Nome}, {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Categoria}";
        }
    }
}
