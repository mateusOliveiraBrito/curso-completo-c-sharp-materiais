using System;
using System.Collections.Generic;
using System.Text;

namespace RefEOut {
    class Triplicador {

        public static void TriplicaPorReferencia(ref int origem) {
            origem = origem * 3;
        }

        public static void TriplicaPorSaida(int origem, out int resultado) {
            resultado = origem * 3;
        }

    }
}
