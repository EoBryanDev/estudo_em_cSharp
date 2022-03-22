using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predicate.Entities;


namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("MOUSE", 50.00));
            list.Add(new Product("TABLET", 350.00));
            list.Add(new Product("HD CASE", 80.90));

            //remove using with lambda expression
            //----------list.RemoveAll(p => p.Price >= 100.0);

            //remove using predicate 
            list.RemoveAll(ProductTest);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
