using System;

namespace Consultoria.Modelo.Entidades
{
    class Produto : IComparable
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new Exception("Erro de validação, o objeto informado não é um produto");
            }

            Produto p = obj as Produto;
            return Preco.CompareTo(p.Preco);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco}";
        }
    }
}
