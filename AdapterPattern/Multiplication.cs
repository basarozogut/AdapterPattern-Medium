using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Multiplication
    {
        public int CalculateMultiplication(int[] numbers)
        {
            var result = 1;

            foreach (var n in numbers)
            {
                result = result * n;
            }

            return result;
        }
    }
}
