using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    internal class ShapeClient
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.CalculateArea();
            r.DisplayDetails();
            Circle c = new Circle();
            c.AcceptDetails();
            c.CalculateArea();
            c.DisplayDetails();
            Shape s = new Rectangle();
            s.AcceptDetails();
            s.CalculateArea();
            s.DisplayDetails();
        }
    }
}
