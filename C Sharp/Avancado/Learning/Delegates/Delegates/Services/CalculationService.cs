using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services
{
    internal class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            Console.WriteLine( (x > y ) ? x : y);
        }
        public static void ShowSum(double x, double y)
        {
            Console.WriteLine( x + y);
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
