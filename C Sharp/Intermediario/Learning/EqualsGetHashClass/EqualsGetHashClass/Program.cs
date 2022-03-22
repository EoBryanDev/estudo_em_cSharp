using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EqualsGetHashClass.Entities;


namespace EqualsGetHashClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client a = new Client("Maria","maria@gmail.com");
            Client b = new Client("Alex", "alex@gmail.com");
            Console.WriteLine(a.Equals(b));


            Console.ReadKey();
        }
    }
}
