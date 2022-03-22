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

            //using action method instanced
            //-----Action<Product> act = UpdatePrice;
            //-----list.ForEach(act);
            //using a external ACTION method 
            //-----list.ForEach(UpdatePrice);

            //resolving updating with lambda expression storaging in a variable
            //-----Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //-----list.ForEach(act);
            //resolving updating with lambda expression inline
            list.ForEach(p => { p.Price += p.Price * 0.1 ; });

            foreach (Product p in list)
            {
                Console.WriteLine(p) ;
            }
          
            Console.ReadKey();
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
