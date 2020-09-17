using System;
using System.Globalization;

namespace TiposBasicos {
    class Program {
        static void Main(string[] args) {

            sbyte primeiroTeste = 127;
            byte segundoTeste = 156;
            int terceiroTeste = 2147483647;
            long quartoTeste = 2147483649L;
            bool quintoTeste = true;
            char sextoTeste = '\u0041'; // \u serve para indicar que logo em seguida será inserido um valor unicode ('\u0041' = 'A')
            float setimoTeste = 4.5f; // 'f' é para explícitar que é uma variável do tipo float, senão o c# entende que é do tipo double
            string oitavoTeste = "Mateus";
            object nonoTeste = 5;

            int min = int.MinValue;
            int max = int.MaxValue;

            Console.WriteLine("Tipo sbyte: {0}", primeiroTeste);
            Console.WriteLine("Tipo byte: {0}", segundoTeste);
            Console.WriteLine("Tipo int: {0}", terceiroTeste);
            Console.WriteLine("Tipo long: {0}", quartoTeste);
            Console.WriteLine("Tipo bool: {0}", quintoTeste);
            Console.WriteLine("Tipo char: {0}", sextoTeste);
            Console.WriteLine("Tipo float: {0}", setimoTeste);
            Console.WriteLine("Tipo string: {0}", oitavoTeste);
            Console.WriteLine("Tipo object: {0}", nonoTeste);
            Console.WriteLine("Tipo min int: {0}", min);
            Console.WriteLine("Tipo max int: {0}", max);

            Console.Write("Teste");
            Console.WriteLine("Teste com quebra de linha");
            Console.WriteLine("===============================================");

            string nome = "Mateus Oliveira";
            char genero = 'M';
            int idade = 19;
            double saldo = 839.5055118;

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("===============================================");

            //Utilizando placeholders
            Console.WriteLine("{0} tem {1} anos e seu saldo é de R$ {2:F2}", nome, idade, saldo);

            //Utilizando interpolação
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é de R$ {saldo:F2}");

            //Utilizando concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é de R$ " + saldo.ToString("F2"));
        }
    }
}
