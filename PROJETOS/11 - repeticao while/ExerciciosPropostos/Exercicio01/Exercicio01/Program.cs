using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            int senha = 2002;
            bool acessoPermitido = false;

            while (acessoPermitido == false) {
                Console.Write("Digite a senha: ");
                int senhaInserida = int.Parse(Console.ReadLine());

                if (senha == senhaInserida) {
                    Console.WriteLine("Acesso Permitido!");
                    acessoPermitido = true;
                } else {
                    Console.WriteLine("Senha Inválida!");
                }
            }
        }
    }
}
