using PrjEnum.Entidades;
using PrjEnum.Entidades.Enums;
using System;

namespace PrjEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido()
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);

            string status = PedidoStatus.PagamentoPendente.ToString();
            Console.WriteLine(status);

            int idPedido = (int)PedidoStatus.Entregue;
            Console.WriteLine(idPedido);

            PedidoStatus ss = Enum.Parse<PedidoStatus>("Entregue");
            Console.WriteLine(ss);
        }
    }
}
