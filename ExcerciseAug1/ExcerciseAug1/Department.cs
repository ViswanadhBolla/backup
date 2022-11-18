using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseAug1
{
    internal class Department
    {
        int DepartmentID;
        string Dname;

        public Department(int DepartmentID, string Dname)
        {
            this.DepartmentID = DepartmentID;
            this.Dname = Dname;
        }
        public void setValues()
        {
            Console.Write("Enter department ID: ");
            DepartmentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Dept name: ");
            Dname = Console.ReadLine();
        }

        

    }


}
