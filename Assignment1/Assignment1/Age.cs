using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Age
    {
        public DateTime dob; 
        public  void FindAgeLeap()
        {
            Console.Write("Enter your D.O.B: ");
            this.dob = Convert.ToDateTime(Console.ReadLine());
            int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            Console.WriteLine(Years);
            int year = dob.Year;
            bool result = DateTime.IsLeapYear(year);
            if (result)
            {
                Console.WriteLine("is leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }

        }
    }
}
