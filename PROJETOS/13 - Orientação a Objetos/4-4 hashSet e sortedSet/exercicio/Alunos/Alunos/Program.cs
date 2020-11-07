using Alunos.Entidades;
using System;
using System.Collections.Generic;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Aluno> A = new HashSet<Aluno>();
            HashSet<Aluno> B = new HashSet<Aluno>();
            HashSet<Aluno> C = new HashSet<Aluno>();

            List<HashSet<Aluno>> cursos = new List<HashSet<Aluno>>();

            int n;

            Console.Write("Quantos alunos para o curso A? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                A.Add(new Aluno(int.Parse(Console.ReadLine())));
            }
            cursos.Add(A);

            Console.Write("Quantos alunos para o curso B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                B.Add(new Aluno(int.Parse(Console.ReadLine())));
            }
            cursos.Add(B);

            Console.Write("Quantos alunos para o curso C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                C.Add(new Aluno(int.Parse(Console.ReadLine())));
            }
            cursos.Add(C);

            Console.WriteLine();
            Console.WriteLine("Total de alunos: " + TotalAlunos(cursos));
        }

        public static int TotalAlunos(List<HashSet<Aluno>> cursos)
        {
            HashSet<Aluno> totalAlunos = new HashSet<Aluno>(cursos[0]);
            totalAlunos.UnionWith(cursos[1]);
            totalAlunos.UnionWith(cursos[2]);

            return totalAlunos.Count;
        }
    }
}
