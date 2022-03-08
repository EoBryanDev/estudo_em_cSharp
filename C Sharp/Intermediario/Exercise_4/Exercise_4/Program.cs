using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_4.Entities;
using System.Globalization;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            

            // Product product = new Product("Tablet",1100.00);
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c_u_i = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c_u_i == 'c')
                {

                    Product product1 = new Product(name,price);
                    product.Add(product1);

                } else if(c_u_i == 'u')
                {
                    
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    
                    Product product2 = new UsedProduct(name,price,date);
                    product.Add(product2);

                }else if(c_u_i == 'i')
                {
                    Console.Write("Customs fee: $ ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product3 = new ImportedProduct(name, price, customFee);
                    product.Add(product3);
                }
                

                

                

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product products in product)
            {
                Console.WriteLine(products.priceTag());
            }
            Console.ReadKey();


        }
    }
}
