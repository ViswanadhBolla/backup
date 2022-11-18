using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Hashseteg
    {
        
        public static void Main(string[] args)
        {
            HashSet<string> cities = new HashSet<string>();
            cities.Add("Delhi");
            cities.Add("Pune");
            cities.Add("Chennai");
            cities.Add("Delhi");
            cities.Add("Pune");
            cities.Add("Chennai");
            cities.Add("Delhi");
            cities.Add("Pune");
            cities.Add("Chennai");

            foreach(var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
