using System;
using System.Globalization;

namespace CompararObjeto.Entidades
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        /*
         * O parâmetro definido aqui para comparação dos objetos do tipo funcionário, é o atributo Nome
         * Cada implementação do método CompareTo apartir da implementação da interface, deve possuir o parâmetro
         * utilizado para fins de comparação dos objetos;
         */
        public int CompareTo(object obj)
        {
            //programação defensiva: objeto precisa ser do tipo Funcionario
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro de comparação: o objeto não é do tipo Funcionário!");
            }

            Funcionario funcionario = obj as Funcionario;
            return Nome.CompareTo(funcionario.Nome);
        }
    }
}
