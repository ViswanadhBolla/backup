using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        public void StudentDetails()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            int[] marks = new int[5];
            int sums = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter sub{i + 1} marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sums = sums + marks[i];
            }
            float Average = sums / 5;

            if (Average > 90.0f)
            {
                Console.WriteLine("Outstanding");
            }
            else if (Average > 65.0f)
            {
                Console.WriteLine("Excellent");
            }
            else if (Average > 40.0f)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
