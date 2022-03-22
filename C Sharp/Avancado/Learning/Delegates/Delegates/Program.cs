using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.Services;

namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a = 10;
            double b = 12;

            //i also could use
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //but it's so long.
            BinaryNumericOperation op = CalculationService.Sum;

            // i also could use result = op.Invoke(a,b)
            double result = op(a, b);
            Console.WriteLine(result);
            /*
            List<double> list = new List<double>();

            double result = CalculationService.Sum(a, b);
            list.Add(result);
            double result2 = CalculationService.Max(a, b);
            list.Add(result2);
            double result3 = CalculationService.Square(a);
            list.Add(result3);

            Console.Write("[ ");
            foreach (double results in list)
            {
                Console.Write($"{results} ,");
            }
            Console.Write(" ] ");*/




            Console.ReadKey();
        }
    }
}
