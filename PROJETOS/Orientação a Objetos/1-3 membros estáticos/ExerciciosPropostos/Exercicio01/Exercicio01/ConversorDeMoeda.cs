using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01 {
    class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double DolarParaReal(double quantida, double cotacao) {
            double total = quantida * cotacao;
            return total + total * Iof / 100;
        }
    }
}
