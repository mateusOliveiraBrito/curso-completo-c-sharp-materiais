using HashCodeEqualsPersonalizado.Entidades;
using System;

namespace HashCodeEqualsPersonalizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente("Mateus", "m@email.com");
            Cliente a2 = new Cliente("Mateus", "m@email.com");
            Cliente b = new Cliente("Altair", "a@email.com");

            Console.WriteLine(a.Equals(a2));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            if (a.GetHashCode() == b.GetHashCode())
            {
                Console.WriteLine("IGUAIS");
            }
            else
            {
                Console.WriteLine("DIFERENTES");
            }

            if (a.GetHashCode() == a2.GetHashCode())
            {
                Console.WriteLine("IGUAIS");
            }
            else
            {
                Console.WriteLine("DIFERENTES");
            }
        }
    }
}
