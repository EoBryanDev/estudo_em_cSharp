using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise_4.Entities
{
    internal class ImportedProduct : Product
    {
        //ATTRIBUTES
        public double CustomFee { get; set; }

        //CONSTRUCTOR - OVERRIDE
        public ImportedProduct() { }

        public ImportedProduct(string name, double price,double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        //METHODS
        public override string priceTag()
        {

            string priceTag = $"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";

            return priceTag;
        }
        public double totalPrice()
        {
            double totalPrice = CustomFee + Price;
            return totalPrice;
        }
    }
}
