using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise_4.Entities
{
    internal class Product
    {
        //ATTIBUTES
        public string Name { get; set; }
        public double Price { get; set; }

        //CONSTRUCTORS - OVERLOAD
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //METHODS
        public virtual string priceTag()
        {
            string priceTag = $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
            return priceTag;

        }

    }
}
