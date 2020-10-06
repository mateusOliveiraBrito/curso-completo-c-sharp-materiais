using System;
using System.Globalization;

namespace DateTimePrj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2020, 10, 06);
            DateTime data2 = new DateTime(2020, 10, 06, 08, 09, 25);
            DateTime data3 = new DateTime(2020, 10, 06, 08, 09, 25, 500);

            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);

            DateTime data4 = DateTime.Now;
            Console.WriteLine(data4);

            DateTime data5 = DateTime.Today;
            Console.WriteLine(data5);

            DateTime data6 = DateTime.UtcNow;
            Console.WriteLine(data6);

            /*
             ************************************************
             ************************************************
             ************************************************
             */


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            DateTime d1 = DateTime.Parse("2020-08-15");
            Console.WriteLine(d1);

            DateTime d2 = DateTime.Parse("2020-08-15 13:05:08");
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Parse("20/10/2020 15:25:33");
            Console.WriteLine(d3);

            DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.ParseExact("15-08-2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
        }
    }
}
