using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro para C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro para D: ");
            int d = int.Parse(Console.ReadLine());

            int resultado = (a * b) - (c * d);

            Console.WriteLine("DIFERENÇA = {0}", resultado);
        }
    }
}
