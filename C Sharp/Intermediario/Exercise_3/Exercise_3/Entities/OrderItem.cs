using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_3.Entities;
using System.Globalization;

namespace Exercise_3.Entities
{
    internal class OrderItem
    {


        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }



        public OrderItem() { }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
          
            
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + 
                ", $" 
                +", Quantity,"
                +Quantity
                +", Subtotal: $"
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
