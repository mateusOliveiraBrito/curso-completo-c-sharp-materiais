using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentaSalario(double porcentagem)
        {
            this.Salario += this.Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
