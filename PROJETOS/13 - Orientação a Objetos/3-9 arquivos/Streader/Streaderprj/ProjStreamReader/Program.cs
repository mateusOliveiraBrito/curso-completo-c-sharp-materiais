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

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            finally
            {
                if (sr != null)
                    sr.Close();

                if (fs != null)
                    fs.Close();
            }
        }
    }
}
