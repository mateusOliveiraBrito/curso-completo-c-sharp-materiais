using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambda.Entidades
{
    class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Nota { get; private set; }

        public Categoria(int id, string nome, int nota)
        {
            Id = id;
            Nome = nome;
            Nota = nota;
        }

        public override string ToString()
        {
            return $@"{Id}, {Nome}, {Nota}";
        }
    }
}
