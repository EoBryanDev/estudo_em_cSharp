using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.Services;

namespace Delegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //or i also can use the long term-> op.Invoke(a, b); or
            //the short term
            op(a, b);

            Console.ReadKey();
        }
    }
}
