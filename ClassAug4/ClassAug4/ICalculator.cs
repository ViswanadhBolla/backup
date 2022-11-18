using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug4
{
    internal interface ICalculator
    {
        int add(int x , int y);
        int subtract(int x , int y);
        int multiply(int x , int y);
        int divide(int x , int y);

        string message(string companyname)
        {
            return "Hi " + companyname;
        }
    }
}
