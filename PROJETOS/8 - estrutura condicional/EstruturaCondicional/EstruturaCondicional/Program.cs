using System;

namespace EstruturaCondicional {
    class Program {
        static void Main(string[] args) {
            //PRIMEIRO EXEMPLO
            /*int x = 10;

            Console.WriteLine("Bom dia");

            if (x > 5) {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");*/

            //SEGUNDO EXEMPLO
            /*Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine($"{n} é par!");
            }
            else {
                Console.WriteLine($"{n} é ímpar!");
            }*/

            //TERCEIRO EXEMPLO
            Console.Write("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) 
                Console.WriteLine("Bom dia!");
             else if (hora < 18) 
                Console.WriteLine("Boa tarde!");
            else if (hora >= 18) 
                Console.WriteLine("Boa noite!");
        }
    }
}
