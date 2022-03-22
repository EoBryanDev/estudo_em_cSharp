using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Linq step characteristics :
                1° Specify data source ex. array, db...
                2° Define query expression
                3° Execute mechanism
             */

            // Specifying data source
            int[] numbers = new int[] { 2,3,4,5};

            // Setting query expression
            var result = numbers
                .Where(x => x % 2 == 0) // fetching specified values
                .Select(x => x * 10); // treating values found

            // Executing query
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
