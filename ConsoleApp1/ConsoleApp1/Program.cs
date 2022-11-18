using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your DOB: ");
            DateTime DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter average: ");
            float avg = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the result: ");
            bool status = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Marks :{0} and {1}",marks,DOB.ToShortDateString());
            Console.WriteLine($"Average {avg}");
            Console.WriteLine("Result : "+ status);

        }
    }
}