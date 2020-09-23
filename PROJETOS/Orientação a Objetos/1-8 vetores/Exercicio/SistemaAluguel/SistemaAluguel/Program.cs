using System;

namespace SistemaAluguel {
    class Program {
        static void Main(string[] args) {

            Aluguel[] alugueis = Adiciona(LeituraInicial());
            ListaAlugueis(alugueis);
        }

        public static int LeituraInicial() {
            Console.Write("Quantos quartos serão alugados? ");
            int qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return qnt;
        }

        public static Aluguel[] Adiciona(int qnt) {
            Aluguel[] alugueis = new Aluguel[qnt];

            for (int i = 0; i < qnt; i++) {
                Console.WriteLine($"Alguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Aluguel aluguel = new Aluguel(nome, email, quarto);

                alugueis[i] = aluguel;
            }

            return alugueis;
        }

        public static void ListaAlugueis(Aluguel[] alugueis) {
            Console.WriteLine("Quartos ocupados: ");
            Aluguel[] quartosOcupados = new Aluguel[10];

            for (int i = 0; i < alugueis.Length; i++) {
                quartosOcupados[alugueis[i].Quarto] = alugueis[i];
            }

            for (int i = 0; i < quartosOcupados.Length; i++) {
                if (quartosOcupados[i] != null) {
                    Console.WriteLine(quartosOcupados[i]);
                }
            }
        }
    }
}
