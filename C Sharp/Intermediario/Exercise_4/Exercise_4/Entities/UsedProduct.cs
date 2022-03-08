using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise_4.Entities
{
    internal class UsedProduct : Product
    {
        //ATTRIBUTE
        public DateTime ManufactureDate { get; set; }

        //CONSTRUCTOR  + OVERLOAD

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
           
            string priceTag = $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";

            return priceTag;
        
    }
    }
}
