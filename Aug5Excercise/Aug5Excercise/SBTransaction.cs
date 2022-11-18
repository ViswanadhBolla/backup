using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug5Excercise
{
    internal class SBTransaction:SBAccount
    {
        string transactionID;
        long tAccountNumber;
        DateTime transactionDate;
        float transactionAmount, newBalance;

        private static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public SBTransaction()
        {
             

        }

        public SBTransaction(SBAccount acc)
        {
            transactionID = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            tAccountNumber = acc.accountNumber;

        }

    }

    
}
