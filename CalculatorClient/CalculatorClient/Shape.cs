using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    abstract class Shape
    {
        public string color { get; set; }
        protected float area;

        public virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the color");
            color = Console.ReadLine();
        }


        public abstract void CalculateArea();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Color :" + color);
            Console.WriteLine("Area : " + area);
        }

    }

        class Rectangle : Shape
        {
            float length, breadth;

            public override void AcceptDetails()
            {
                base.AcceptDetails();
                Console.WriteLine("Enter lenght and breadth:");
                float.TryParse(Console.ReadLine(), out length);
                float.TryParse(Console.ReadLine(), out breadth);

            }

            public override void CalculateArea()
            {
                area = length*breadth;
            }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("Length :"+length);
                Console.WriteLine("Breadth :"+breadth);
            }
        }

        class Circle : Shape
        {
            float radius;

            public override void AcceptDetails()
            {
                base.AcceptDetails();
                Console.WriteLine("Enter the radius:");
                float.TryParse(Console.ReadLine(),out radius);
            }

            public override void CalculateArea()
            {
                area = 3.14f * radius * radius;
            }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("radius :"+radius);
            }
        }


    
}
