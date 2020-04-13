using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_e_prop.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, int price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;

        }

        public override string ToString()
        {
            return "testando"; 
        }
    }
}
