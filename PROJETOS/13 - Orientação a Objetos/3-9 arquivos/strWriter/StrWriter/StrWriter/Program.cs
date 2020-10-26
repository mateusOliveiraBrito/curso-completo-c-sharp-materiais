using System;
using System.IO;

namespace StrWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                string[] linhas = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(var item in linhas)
                    {
                        sw.WriteLine(item.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }
    }
}
