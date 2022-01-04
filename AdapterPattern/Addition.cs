using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Addition : IMathOperation
    {
        private int _a;
        private int _b;

        public Addition(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int Calculate()
        {
            return _a + _b;
        }
    }
}
