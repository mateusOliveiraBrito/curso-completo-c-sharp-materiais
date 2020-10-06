using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            // double x = null; -> não permitido pelo C#

            // maneira mais complexa:
            //Nullable<double> x = null;

            // maneira simples:
            double? x = null; // indica que a variável x, mesmo sendo de tipo valor, poderá receber um valor nulo
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // pega o valor do x, se não existir pega o valor padrão do tipo (zero, no caso do double)
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //retorna se a variável tem ou não um valor
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é vazio");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y é vazio");

            double a = x ?? 0.5;
            double b = y ?? 15;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
