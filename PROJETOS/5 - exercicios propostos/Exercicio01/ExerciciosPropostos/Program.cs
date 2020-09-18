using System;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o primeiro valor inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro:");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = {0}", soma);
        }
    }
}
