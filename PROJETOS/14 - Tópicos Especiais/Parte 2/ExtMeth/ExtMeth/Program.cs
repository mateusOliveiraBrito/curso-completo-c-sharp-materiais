using ExtMeth.Extensions;
using System;

namespace ExtMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 07, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Bom dia, você tem novos emails ainda não lidos!";
            Console.WriteLine(s1.Cut(20));
        }
    }
}
