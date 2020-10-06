using System;

namespace TimeSpanPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(1, 30, 15); //hh mm ss
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //dd hh mm ss
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); //dd hh mm ss ms

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            TimeSpan time1 = TimeSpan.FromDays(1.5);
            TimeSpan time2 = TimeSpan.FromHours(1.5);
            TimeSpan time3 = TimeSpan.FromMinutes(1.5);
            TimeSpan time4 = TimeSpan.FromSeconds(1.5);
            TimeSpan time5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan time6 = TimeSpan.FromTicks(900000000L); //só aceita valores inteiros por ser a menor medida

            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);
        }
    }
}
