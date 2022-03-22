using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }
            CalculationService calculationService = new CalculationService();
            int max = calculationService.Max(list);

            Console.WriteLine($"Max: {max}");

            Console.ReadKey();

            
        }
    }
}
