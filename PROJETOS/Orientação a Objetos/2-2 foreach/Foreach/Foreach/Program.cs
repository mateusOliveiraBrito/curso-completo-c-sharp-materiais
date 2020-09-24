using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {
            string[] nomes = { "mateus", "oliveira", "brito" };

            foreach(string nome in nomes) {
                Console.WriteLine(nome);
            }
        }
    }
}
