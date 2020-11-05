using CompararObjeto.Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace CompararObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    //o método sort faz uso da interface IComparable, assim sendo, o objeto da lista que ele irá ordenar,
                    //deve conter a implementação da interface IComparable
                    list.Sort();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
