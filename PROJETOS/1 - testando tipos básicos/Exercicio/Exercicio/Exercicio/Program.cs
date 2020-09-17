using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($@"Produtos:
                                {produto1}, cujo preço é R$ {preco1.ToString("F2")}
                                {produto2}, cujo preço é R$ {preco2.ToString("F2")}

                                Registro: {idade} anos de idade, código {codigo} e gênero: {genero}

                                Medida com oito casas decimais: {medida.ToString("F8")}
                                Arredondando (três casas decimais): {medida.ToString("F3")}
                                Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
