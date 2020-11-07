using System;
using System.Collections.Generic;

namespace Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria.com";
            cookies["fone"] = "40028922";
            cookies["fone"] = "993964985"; // por serem a mesma chave, a segunda atribuição sobrescreve a primeira

            Console.WriteLine(cookies["email"]);

            try
            {
                cookies.Remove("email");
                Console.WriteLine(cookies["email"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chave inexistente");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);
            Console.WriteLine("TODOS OS COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
