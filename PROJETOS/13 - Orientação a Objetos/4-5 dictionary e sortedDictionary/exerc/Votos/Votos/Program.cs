using System;
using System.Collections.Generic;
using System.IO;

namespace Votos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> registros = new Dictionary<string, int>();

            string path = @"c:\temp\votos\registros.csv";

            using (StreamReader str = File.OpenText(path))
            {
                while (!str.EndOfStream)
                {
                    string[] linha = str.ReadLine().Split(',');

                    if (registros.ContainsKey(linha[0]))
                    {
                        registros[linha[0]] += int.Parse(linha[1]);
                    }
                    else
                    {
                        //registros[linha[0]] = int.Parse(linha[1]);
                        registros.Add(linha[0], int.Parse(linha[1]));
                    }
                }

                foreach (var item in registros)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
