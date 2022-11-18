using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Welcome
    {
        public int number;
        public void Greetings()
        {
            Console.Write("Enter the number of students : ");
            this.number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < this.number; i++)
            {
                Console.WriteLine($"Welcome Student{i + 1}");
            }
        }
    }
}
