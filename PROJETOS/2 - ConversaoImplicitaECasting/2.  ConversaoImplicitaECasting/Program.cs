using System;

namespace _2.__ConversaoImplicitaECasting {
    class Program {
        static void Main(string[] args) {

            //CONVERSÃO IMPLÍCITA DE TIPOS
            float x = 4.5f;
            double y = x;

            //TESTE
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado);

            //CONVERSÃO EXPLÍCITA DE TIPOS
            double c;
            int d;

            c = 5.1;
            d = (int) c;
            Console.WriteLine(d);
        }
    }
}
