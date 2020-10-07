using CadastroDePedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CadastroDePedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Client Client { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }

        public Order(DateTime moment, OrderStatus status, Client client) : this()
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double valueTotal = 0.0;
            foreach (var item in Items)
            {
                valueTotal += item.SubTotal();
            }

            return valueTotal;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Order moment: ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.Append("Order status: ");
            builder.AppendLine(Status.ToString());
            builder.Append("Client: ");
            builder.Append(Client.Name);
            builder.Append(" (");
            builder.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            builder.Append(") - ");
            builder.AppendLine(Client.Email);
            builder.AppendLine("Order items:");

            foreach(var item in Items)
            {
                builder.AppendLine(item.ToString());
            }

            builder.Append("Total price: $");
            builder.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return builder.ToString();
        }
    }
}
