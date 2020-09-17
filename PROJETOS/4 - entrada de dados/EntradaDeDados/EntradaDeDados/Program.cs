using System;
using System.Globalization;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            //PRIMEIRA PARTE DO PROJETO
            /*string frase, x, y, z, a, b, c;

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
            Console.WriteLine("{0} {1} {2}", a, b, c);*/

            //SEGUNDA PARTE DO PROJETO
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: {0}", n1);
            Console.WriteLine("Você digitou: {0}", ch);
            Console.WriteLine("Você digitou: {0}", n2);

            string nome;
            char sexo;
            int idade;
            double altura;

            Console.WriteLine("Digite os dados:");

            string[] dados = Console.ReadLine().Split(' ');

            nome = dados[0];
            sexo = char.Parse(dados[1]);
            idade = int.Parse(dados[2]);
            altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine("{0} {1} {2} {3}", nome, sexo, idade, altura);
        }
    }
}
