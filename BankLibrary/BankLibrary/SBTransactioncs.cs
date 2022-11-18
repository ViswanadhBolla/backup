using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SBTransactioncs
    {
        public string transactionId { get; } 
        public string TransactionType { get; }
        public DateTime transactionDate { get; }
        public long accountNumber { get; }
        public float amount { get; }
        private static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public SBTransactioncs()
        {
            
        }
        public SBTransactioncs(long accountNumber,float amount)
        {
            transactionId = new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            transactionDate = DateTime.Now;
            this.accountNumber = accountNumber;
            this.amount = amount;
            if (amount > 0.00f)
            {
                TransactionType = "Deposit";
            }
            else if(amount < 0.00f)
            {
                TransactionType = "Withdrawl";
            }
        }

        public string printDetails()
        {
            string details = String.Format("Transaction Number: " + transactionId
                + "\naccount Number: " + accountNumber
                + "\ntransaction ammount: " + amount
                + "\ntransaction Date: "+transactionDate
                + "\ntransaction Type: "+TransactionType);
            return details;
        }

    }
}
