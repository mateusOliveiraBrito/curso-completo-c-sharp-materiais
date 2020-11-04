using ProductsTable.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ProductsTable
{
    class Program
    {
        //há maneiras mais simples de realizar os procedimentos deste projeto
        //entretanto, para fins acadêmicos, a implementação seguiu desta maneira
        static void Main(string[] args)
        {
            string path = @"c:\temp\products\";
            string newPath = @"c:\temp\products\out";
            List<Product> productsOrigem = new List<Product>();
            StreamReader sr = File.OpenText(path + @"products.csv");

            try
            {
                //Lendo arquivo .csv, criando os objetos e preenchendo a lista 
                while (!sr.EndOfStream)
                {
                    string product = sr.ReadLine();
                    Console.WriteLine(product);

                    string name = product.Split(',')[0];
                    double price = double.Parse(product.Split(',')[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(product.Split(',')[2]);

                    productsOrigem.Add(new Product(name, price, quantity));
                }

                //Criando novo diretório de pastas para a lista de produtos com preço total
                Directory.CreateDirectory(newPath);

                //Criando arquivo summary
                using (StreamWriter stw = File.AppendText(newPath + @"\summary.csv"))
                {
                    foreach (var item in productsOrigem)
                    {
                        stw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
            finally
            {
                if (sr == null)
                {
                    sr.Close();
                }
            }
        }
    }
}
