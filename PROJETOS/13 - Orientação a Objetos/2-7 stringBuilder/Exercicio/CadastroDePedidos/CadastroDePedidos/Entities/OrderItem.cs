using System.Globalization;
using System.Text;

namespace CadastroDePedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
            Product = new Product();
        }

        public OrderItem(int quantity, double price, Product product) : this()
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", ");
            sb.Append(Product.Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
