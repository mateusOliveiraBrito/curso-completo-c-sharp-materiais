using System;
using System.Globalization;
using System.IO;

namespace ProjStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
