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
            list.Add(new Product("TABLET", 350.50));
            list.Add(new Product("HD CASE", 80.90));

            //using direct external reference on method selelect
            //------List<string> result = list.Select(NameUpper).ToList();

            //using declarated delegate with external reference included
            //------Func<Product, string> func = NameUpper;
            //------List<string> result = list.Select(func).ToList();

            //using lambda expression to return UpperCase list updated
            //we didn't use keys in that lambda expression 'cuz its expected a return, with keys don't.
            //-----Func<Product,string> func = p => p.Name.ToUpper();

            //using lambda expression inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
        /* external support shifter method 
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }*/
    }
}
