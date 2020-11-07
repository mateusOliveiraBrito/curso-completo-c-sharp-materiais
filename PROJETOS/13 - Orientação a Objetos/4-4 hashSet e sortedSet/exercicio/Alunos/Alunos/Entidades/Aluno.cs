using System;

namespace Alunos.Entidades
{
    class Aluno
    {
        public int Codigo { get; private set; }

        public Aluno(int codigo)
        {
            Codigo = codigo;
        }

        public override string ToString()
        {
            return Codigo.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aluno))
                throw new ArgumentException("Erro: O objeto informado não é um aluno");

            Aluno aluno = obj as Aluno;

            if (Codigo != aluno.Codigo)
                return false;
            else
                return true;
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }
    }
}
