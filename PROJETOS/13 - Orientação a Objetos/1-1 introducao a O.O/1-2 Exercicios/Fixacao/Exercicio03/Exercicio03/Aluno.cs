using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03 {
    class Aluno {
        public string Nome;
        public double[] notas = new double[3];

        public double CalcularNotaFinal(double n1, double n2, double n3) {
            double media = (n1 * 30) + (n2 * 35) + (n3 * 35);
            return media;
        }

        public string Resultado(double media) {
            string resultado;
            if (media >= 600) {
                resultado = "APROVADO";
            } else {
                double falta = 600 - media;
                resultado = $"REPROVADO, faltam {falta} pontos para atingir média 6";
            }
            return resultado;
        }
    }
}
