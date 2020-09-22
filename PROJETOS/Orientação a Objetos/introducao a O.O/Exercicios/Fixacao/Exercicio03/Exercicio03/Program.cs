using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            for (int i = 1; i <= 3; i++) {
                Console.Write($"Digite a nota do {i}° trimestre: ");
                aluno.notas[i - 1] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Nota final = {aluno.CalcularNotaFinal(aluno.notas[0], aluno.notas[1], aluno.notas[2])}");
            Console.WriteLine(aluno.Resultado(aluno.CalcularNotaFinal(aluno.notas[0], aluno.notas[1], aluno.notas[2])));
        }
    }
}
