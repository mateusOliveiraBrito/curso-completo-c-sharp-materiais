using System;

namespace DateTimeKindIso8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); //instanciando a data e definindo o kind manualmente
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //padrão ISO 8601
            DateTime d = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d);

            DateTime dd = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine(dd);


            Console.WriteLine("d: " + d);
            Console.WriteLine("d Kind: " + d.Kind);
            Console.WriteLine("d to Local: " + d.ToLocalTime());
            Console.WriteLine("d to Utc: " + d.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dd: " + dd);
            Console.WriteLine("dd Kind: " + dd.Kind);
            Console.WriteLine("dd to Local: " + dd.ToLocalTime());
            Console.WriteLine("dd to Utc: " + dd.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dd.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(dd.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
