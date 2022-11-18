using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aug5Excercise
{
    internal class SBAccount
    {
        public long accountNumber { get; }
        string accountHolderName, typeofAccount;
        DateTime dateofCreation;
        public float balance { get; protected set; }
        static long AccNum = 100000000001;

        ArrayList AccountTypes = new ArrayList() { "Savings" , "Current", "Salary" };
        


        public SBAccount()
        {
            accountNumber = AccNum;
            AccNum=AccNum+1;
            accountHolderName = "John Doe";
            typeofAccount = "Savings";
            dateofCreation = DateTime.Now;
            balance = 5000.00f;
        }

        public SBAccount(string typeofAccount)
        {
            accountNumber = AccNum;
            AccNum = AccNum + 1;
            accountHolderName = "John Doe";
            TypeofAccount = typeofAccount;
            dateofCreation = DateTime.Now;
            balance = 5000.00f;
        }


        

        public string AccountHolderName
        {
            get { return accountHolderName; }

            set
            {
                if (value != "") { accountHolderName = value; }
                
                
            }
        }

        public string TypeofAccount
        {
            get { return typeofAccount; }

            set
            {
                if (AccountTypes.Contains(value))
                {
                    typeofAccount= value;
                }
            }
        }

        public void setDetails()
        {
            Console.Write("Enter Account holder's name: ");
            AccountHolderName = Console.ReadLine();
            #region
            //Console.WriteLine("Select account type:\n1.Savings.\n2.Current.\n3.Salary.");
            //TypeofAccount = Console.ReadLine();
            #endregion
            
        }


        public void printDetails()
        {
            Console.WriteLine(String.Format("Account Number : "+accountNumber
                +"\nAccount holder's name : "+AccountHolderName
                +"\nAccount type : "+TypeofAccount
                +"\nBalance : " + balance 
                +"\nDate of Creation : "+dateofCreation));
        }



    }
}
