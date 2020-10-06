using System;

namespace RefEOut {
    class Program {
        static void Main(string[] args) {
            int x = 5;
            int y = 3;
            int saida;

            Console.WriteLine("Antes do cálculo: ");
            Console.WriteLine($"X = {x} || Y = {y}");
            Triplicador.TriplicaPorReferencia(ref x);
            Triplicador.TriplicaPorSaida(y, out saida);

            Console.WriteLine();
            Console.WriteLine("Depois do cálculo: ");
            Console.WriteLine($"X = {x} || Y = {saida}");
        }
    }
}
