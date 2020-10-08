using Heranca.Entities;
using System;
using System.Collections.Generic;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> lista = new List<Account>();

            lista.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            lista.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            lista.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            lista.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach(var item in lista)
            {
                sum += item.Balance;
            }

            Console.WriteLine(sum);

            Console.WriteLine();

            foreach (var item in lista)
            {
                item.WithDraw(10.0);
            }

            foreach(var item in lista)
            {
                Console.WriteLine(item.Balance);
            }
        }
    }
}
