using System;
using System.IO;

namespace PathPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myFolder\file1.txt";

            Console.WriteLine("Caracter separador do diretorio: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Separador de caminho: " + Path.PathSeparator);
            Console.WriteLine("Pega o nome do diretório: " + Path.GetDirectoryName(path));
            Console.WriteLine("Nome do arquivo: " + Path.GetFileName(path));
            Console.WriteLine("Extensão do arquivo: " + Path.GetExtension(path));
            Console.WriteLine("Nome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Todo o caminho: " + Path.GetFullPath(path));
            Console.WriteLine("Pasta temporária do sistema: " + Path.GetTempPath()); //serve para trabalhar com arquivos temporários
        }
    }
}
