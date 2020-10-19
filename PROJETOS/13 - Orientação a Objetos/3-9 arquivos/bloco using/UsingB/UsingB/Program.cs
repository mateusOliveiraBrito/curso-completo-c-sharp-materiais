using System;
using System.IO;

namespace UsingB
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            /*
             * dentro dos parênteses do bloco using são instanciados
             * os objetos que deverão ser fechados
            */
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"ERRO: {e.Message}");
            }
        }
    }
}
