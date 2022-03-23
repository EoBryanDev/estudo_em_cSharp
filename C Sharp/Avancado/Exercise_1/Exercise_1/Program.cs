using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_1.Entities;

namespace Exercise_1
{
    internal class Program
    {
        static void Print<T>(string message,IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1,"Tools",2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>
            {
                new Product(1, "Computer", 1100.0,c2),
                new Product(2, "Hammer", 90.0,c1),
                new Product(3, "Tv", 1100.0,c3),
                new Product(4, "Notebook", 1300.0,c2),
                new Product(5, "Saw", 80.0,c1),
                new Product(6, "Tablet", 700.0,c2),
                new Product(7, "Camera", 700.0,c3),
                new Product(8, "Printer", 350.0,c3),
                new Product(9, "MacBook", 1800.0,c2),
                new Product(10, "SoundBar", 700.0,c3),
                new Product(11, "Level", 70.0,c1)

            };
            var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);            
            Print("TIER 1 AND PRICE < 900:", r1);
            var r2 = products.Where(y => y.Category.Name == "Tools").Select(y => y.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS",r2);

            var r3 = products.Where(z => z.Name[0] == 'C').Select(z => new { z.Name, z.Price, CategoryName = z.Category.Name});
            Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);
            

            var r4 = products.Where(w => w.Category.Tier == 1).OrderBy(w => w.Price).ThenBy(w => w.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THE BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine($"First Or Default test1 : {r6}");

            var r7 = products.Where(k => k.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First Or Default test 2: {r7}");
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or default test 1: {r8}");

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"Single or default test 2: {r9}");


            Console.ReadKey();


        }
    }
}
