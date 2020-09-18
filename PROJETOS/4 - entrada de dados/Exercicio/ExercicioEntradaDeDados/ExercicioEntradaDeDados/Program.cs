using System;

namespace ExercicioEntradaDeDados {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeComepleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int nQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            string saida = $@"{nomeComepleto}
                          {nQuartos}
                          {preco.ToString("F2")}
                          {ultimoNome}
                          {idade}
                          {altura.ToString("F2")}";

            Console.WriteLine(saida);
        }
    }
}
