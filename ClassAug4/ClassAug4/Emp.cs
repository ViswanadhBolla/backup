using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug4
{
    internal class Emp
    {
        int eid { get; set; }
        string ename { get; set; }

        public Emp()
        {

        }

        public Emp(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }

        public override string ToString()
        {
            return String.Format("Eid: " + eid+"   Ename: "+ename);
        }
    }
}
