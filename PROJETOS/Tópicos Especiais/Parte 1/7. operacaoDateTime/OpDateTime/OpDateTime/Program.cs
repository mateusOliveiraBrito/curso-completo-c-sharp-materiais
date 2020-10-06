using System;

namespace OpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Data: " + d.Date);
            Console.WriteLine("2) Dia: " + d.Day);
            Console.WriteLine("3) Dia da semana: " + d.DayOfWeek);
            Console.WriteLine("4) Dia do ano: " + d.DayOfYear);
            Console.WriteLine("5) Hora: " + d.Hour);
            Console.WriteLine("6) Tipo (local/global): " + d.Kind); //por padrão é local, mas ele nao especifica se o programador não explicitar isso em código
            Console.WriteLine("7) Mili-segundo: " + d.Millisecond);
            Console.WriteLine("8) Minuto: " + d.Minute);
            Console.WriteLine("9) Mês: " + d.Month);
            Console.WriteLine("10) Segundo: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) Horário do dia: " + d.TimeOfDay);
            Console.WriteLine("13) Ano: " + d.Year);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //trabalhando com formatação
            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine(d2.ToLongDateString()); //converte a data para string
            Console.WriteLine(d2.ToLongTimeString());
            Console.WriteLine(d2.ToShortDateString());
            Console.WriteLine(d2.ToShortTimeString());
            Console.WriteLine(d2.ToString());

            string s = d2.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s);

            string s2 = d2.ToString("yyyy-MM-dd HH:mm:ss.ff");
            Console.WriteLine(s2);

            //operações com dateTime
            DateTime dOp = d.AddHours(2);
            Console.WriteLine(dOp.Hour);
        }
    }
}
