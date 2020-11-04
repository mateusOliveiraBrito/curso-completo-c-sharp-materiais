using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProductsTable.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name + " - " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
