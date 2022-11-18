using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug4
{
    internal class Casio : ICalculator
    {
        public int add(int x, int y)
        {
            return x+y;
        }

        public int divide(int x, int y)
        {
            return x/y;
        }

        public int multiply(int x, int y)
        {
            return x*y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }
    }
}
