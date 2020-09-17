using System;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            string frase, x, y, z, a, b, c;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine(); ;
            z = Console.ReadLine();

            char[] condicoes = {' ', '.', ';'};

            string[] vetor = Console.ReadLine().Split(condicoes);
            a = vetor[0];
            b = vetor[1];
            c = vetor[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
