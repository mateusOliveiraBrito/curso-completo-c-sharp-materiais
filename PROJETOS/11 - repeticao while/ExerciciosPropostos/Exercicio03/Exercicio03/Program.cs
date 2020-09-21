using System;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            int alcool = 0, gasolina = 0, diesel = 0;
            int codigo = 0;

            while (codigo != 4 || (codigo != 1 && codigo != 2 && codigo != 3)) {
                Console.Write("Digite um código: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1) {
                    alcool++;
                }
                else if (codigo == 2) {
                    gasolina++;
                }
                else if (codigo == 3) {
                    diesel++;
                }
                else {
                    Console.WriteLine("Código inválido!");
                    break;
                }
            }

            Console.WriteLine($@"MUITO OBRIGADO! 
                                Alcool: {alcool} 
                                Gasolina: {gasolina} 
                                Diesel: {diesel}");
        }
    }
}
