using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularorAPP
{
    public interface Icalculator
    {
        public int add(int a , int b);
        public int sub(int a, int b);

        public bool checkage(int age);

        public string Message(string name)
        {
            return "Hello " + name;
        }

        public int validData();
    }
}
