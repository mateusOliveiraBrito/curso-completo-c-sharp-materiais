using ExcecoesPersonalizadas.Entidades;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Número do quarto: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Check-in (DD/MM/AAAA): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out (DD/MM/AAAA): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Erro na reserva: Datas cronológicamente incompatíveis!");
            }
            else
            {
                Reserva reserva = new Reserva(numero, checkin, checkout);
                Console.WriteLine($"Reserva: {reserva}");

                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Check-in (DD/MM/AAAA): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (DD/MM/AAAA): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime agora = DateTime.Now;

                if (checkin < agora || checkout < agora)
                {
                    Console.WriteLine("Erro na reserva: data para atualização de reserva, devem ser datas futuras!");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Erro na reserva: Datas cronológicamente incompatíveis!");
                }
                else
                {
                    reserva.UpdateDates(checkin, checkout);
                    Console.WriteLine($"Reserva: {reserva}");
                }
            }
        }
    }
}
