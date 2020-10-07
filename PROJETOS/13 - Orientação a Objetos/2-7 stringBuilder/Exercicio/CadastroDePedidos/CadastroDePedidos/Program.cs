using CadastroDePedidos.Entities;
using CadastroDePedidos.Entities.Enums;
using System;
using System.Globalization;

namespace CadastroDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client() {
                Name = nameClient,
                Email = email,
                BirthDate = dateOfBirth
            };

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order() {
                Moment = DateTime.Now,
                Status = status,
                Client = client
            };

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product() {
                    Name = nameProduct,
                    Price = price
                };

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem() {
                    Quantity = quantity,
                    Price = price,
                    Product = product
                };

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
