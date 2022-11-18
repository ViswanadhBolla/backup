using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug2
{
    internal class Employee
    {
        public static int count = 0;
        int id;
        string name;

        public Employee()
        {
            count = count + 1;
        }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
            count = count + 1;
        }


        public int Id {
            get
            { 
                return id; 
            }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void setDetails()
        {
            Console.Write("Enter employee details : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name: ");
            name = Console.ReadLine();

        }
        public void getDetails()
        {
            Console.WriteLine($"{id} , {name} ,{count}");
        }

       
    }
}
