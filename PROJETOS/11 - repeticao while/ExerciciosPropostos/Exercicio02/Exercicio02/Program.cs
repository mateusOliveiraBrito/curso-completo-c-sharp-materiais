﻿using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {
            int x = -1, y = -1;

            while (x != 0 && y != 0) {
                Console.Write("Digite a coordenada X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite a coordenada Y: ");
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("Quarto");
                }
            }
        }
    }
}
