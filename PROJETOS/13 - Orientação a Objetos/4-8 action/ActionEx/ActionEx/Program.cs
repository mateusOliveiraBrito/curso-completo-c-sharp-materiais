using ActionEx.Entidades;
using System;
using System.Collections.Generic;

namespace ActionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("Tv", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.50));
            list.Add(new Produto("HD Case", 80.90));

            //list.ForEach(p => p.Preco += p.Preco * 0.1);
            //list.ForEach(p => { p.Preco += p.Preco * 0.1; });
            list.ForEach(MudaPreco); //a função informada no parametro do método foreach do list deve retornar void e possuir um objeto por parametro do mesmo tipo da lista

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void MudaPreco(Produto p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }
}
