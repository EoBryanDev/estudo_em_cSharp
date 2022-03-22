using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> cookies = new Dictionary<string,string>();

            cookies["user"] = "maria";

            cookies["email"] = "maria@gmail.com";
            //set some item in on dictionary
            cookies["phone"] = "99999999";

            cookies["phone"] = "11111111";


            Console.WriteLine(cookies["phone"]);

            //remove some item in on dictionary
            cookies.Remove("phone");

            Console.WriteLine($"Size : {cookies.Count}");
            Console.WriteLine("All cookies: ");
            // i can use keyvaluepair or var
            foreach(KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            Console.ReadKey();

        
        }
    }
}
