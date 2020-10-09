using System;

namespace ExcecoesPersonalizadas.Entidades
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkin, DateTime checkout)
        {
            NumeroQuarto = numeroQuarto;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duracao()
        {
            TimeSpan duracao = Checkout.Subtract(Checkin);
            return (int)duracao.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return $"Quarto {NumeroQuarto}, check-in: {Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duracao()} noites";
        }
    }
}
