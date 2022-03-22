using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where 
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can't be empty!");

            }
            T max = list[0];
            for(int i= 1; i < list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
