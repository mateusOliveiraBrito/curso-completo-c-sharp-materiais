using FuncEx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            Func<Product, string> func = NameUpper; //aqui pode receber funcao 
            List<string> result = list.Select(p => { return p.Nome.ToUpper(); }).ToList();
            //List<string> result = list.Select(func).ToList();
            //List<string> result = list.Select(NameUpper).ToList();

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }

        public static string NameUpper(Product p)
        {
            return p.Nome.ToUpper();
        }
    }
}
