using System;

namespace MembrosEstaticos {
    class Calculadora {
        public static double Pi = 3.14;

        public static double Circunferencia(double raio) {
            return 2 * Pi * raio;
        }

        public static double Volume(double r) {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
