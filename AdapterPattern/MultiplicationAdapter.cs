using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MultiplicationAdapter : IMathOperation
    {
        private Multiplication _multiplication;
        private int _a;
        private int _b;

        public MultiplicationAdapter(Multiplication multiplication, int a, int b)
        {
            _multiplication = multiplication;
            _a = a;
            _b = b;
        }

        public int Calculate()
        {
            return _multiplication.CalculateMultiplication(new int[] { _a, _b });
        }
    }
}
