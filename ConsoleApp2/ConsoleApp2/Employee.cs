using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        int eid;
        string ename;
        float salary;

        public Employee()
        {
            eid = 101;
            ename = "abc";
            salary = 5000;
        }

        public Employee(float salary)
        {
            this.salary = salary;
        }
        public Employee(string ename)
        {
            this.ename = ename;
        }
        ~Employee()
        {
            Console.WriteLine("destructor");
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Eid, Ename, salary");
            eid = Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
            salary = float.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("employee details are");
            Console.WriteLine(eid);
            Console.WriteLine(ename);
            Console.WriteLine(salary);  
        }
    }
}
