using System;
using System.IO;

namespace ArquivosPrj
{
    class Program
    {
        static void Main(string[] args)
        {

            //caminho do arquivo de origem
            //a notação @ serve para que não seja necessário digitar \\ no sourcePath
            string sourcePath = @"c:\temp\file1.txt";

            //caminho do arquivo de destino
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                //instancia um objeto com base num arquivo existente
                FileInfo fileInfo = new FileInfo(sourcePath);

                //copia os dados do objeto para um arquivo em um caminho especificado
                fileInfo.CopyTo(targetPath);

                string[] linhas = File.ReadAllLines(sourcePath);

                foreach(var item in linhas)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"ERRO:{e.Message}");
            }
        }
    }
}
