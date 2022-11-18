using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug4
{
    internal class CalculatorClient
    {
        public static void main(string[] args)
        {
            ICalculator cal = new Casio();
            Console.WriteLine(cal.add(2, 3));
            Console.WriteLine(cal.message("Casio"));
            cal = new Samsung();
            Console.WriteLine(cal.multiply(2, 3));
            Console.WriteLine(cal.message("Samsung"));
        }
        
    }
}
