using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularorAPP
{
    public class Emp:IEmp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public float Sal { get; set; }

        public Emp() { }
        public Emp(int eid, string ename, float sal)
        {
            Eid = eid;
            Ename = ename;
            Sal = sal;
        }

        public static List<Emp> Emps = new List<Emp>();

        public  List<Emp> getAllEmployees()
        {
            Emps.Add(new Emp(1, "Ram", 34000));
            Emps.Add(new Emp(2,"Lakshmi",12000));
            return Emps;
        }

    }
}
