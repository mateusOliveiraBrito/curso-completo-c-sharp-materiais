using System;

namespace EstruturaWhile {
    class Program {
        static void Main(string[] args) {
            int n = 0;

            while(n >= 0) {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                
                if(n >= 0) {
                    Console.WriteLine(Math.Sqrt(n).ToString("F3"));
                }
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
