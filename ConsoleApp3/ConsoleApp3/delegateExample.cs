using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class delegateExample
    {
        public delegate void Action();
        public static void Main()
        {
            Dostuff(delegate { Foo(5); });
            Dostuff(delegate { Bar("hello", "world"); });
        }

        static void Dostuff(Action action)
        {
            action();
        }
        static void Foo(int i)
        {
            Console.WriteLine(i);
        }

        static void Bar(string s, string t)
        {
            Console.WriteLine(s+" "+t);
        }
    }
}
