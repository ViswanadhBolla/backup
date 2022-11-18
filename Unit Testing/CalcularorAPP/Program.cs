using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularorAPP
{
    public class Program
    {
        public static void Main()
        {
            Icalculator cal = new Calculator();

            Console.WriteLine(cal.add(2,3));
        }
    }
}