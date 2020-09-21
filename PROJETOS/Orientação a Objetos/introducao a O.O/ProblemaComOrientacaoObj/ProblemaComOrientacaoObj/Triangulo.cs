using System;

namespace ProblemaComOrientacaoObj {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        public double CalculaArea() {
            double p = CalculaP();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private double CalculaP() {
            return (A + B + C) / 2;
        }
    }
}
