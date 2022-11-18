using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug5Excercise
{
    internal class SBClient
    {
        public static void Main(string[] args)
        {
            SBAccount acc1 = new SBAccount();
            acc1.setDetails();
            acc1.printDetails();
            SBAccount acc2 = new SBAccount("Current");
            acc2.setDetails();
            acc2.printDetails();
        }
    }
}
