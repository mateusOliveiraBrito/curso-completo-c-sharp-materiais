using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryDirecInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myFolder";

            try
            {
                /*
                 * LISTAGEM DE PASTAS:
                 * Sobrecarga desse método: caminho base, padrão de busca (máscara de busca) na forma de string 
                 * e opção de busca
                 * 
                 * IEnumerable é um tipo de coleção ainda mais genérico que o tipo List
                 */
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach(var item in folders)
                {
                    Console.WriteLine(item);
                }

                /*
                 * LISTAGEM DE ARQUIVOS:
                 * Código semelhante ao de listagem de pastas
                 */

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");

                foreach(var item in files)
                {
                    Console.WriteLine(item);
                }

                /*
                 * CRIANDO PASTA
                 */
                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
}
