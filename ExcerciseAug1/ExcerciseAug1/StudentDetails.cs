using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseAug1
{
    internal class StudentDetails
    {
        int RegisterNum;
        string Sname;
        int DepID;

        public StudentDetails(int registerNum, string sname, int depID)
        {
            this.RegisterNum = registerNum;
            this.Sname = sname;
            this.DepID = depID;
        }

        public void setValues()
        {
            Console.Write("Enter Reg no : ");
            RegisterNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student name: ");
            Sname = Console.ReadLine();
            Console.Write("Enter department ID: ");
            DepID= Convert.ToInt32(Console.ReadLine());
        }
    }
}
