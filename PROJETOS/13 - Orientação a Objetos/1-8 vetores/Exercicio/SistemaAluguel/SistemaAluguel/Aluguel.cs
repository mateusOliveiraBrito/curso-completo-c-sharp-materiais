using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAluguel {
    class Aluguel {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString() {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}
