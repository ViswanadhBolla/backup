using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ATM
    {
        public float Balance = 5000.0f;
        public string AccountNumber;
        public void Transaction()
        {
            Console.Write("Enter your account Number: ");
            this.AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter 1 withdrawl.\nEnter 2 for desposit.");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                Console.Write("Enter Withdrawl amount : ");
                float amount = float.Parse(Console.ReadLine());
                if (amount > Balance)
                {
                    Console.WriteLine($"amount exceded balance.\nBalance : {Balance}\nPlease Try again.");
                }
                else
                {
                    Console.WriteLine("amount Withdrawn");
                    this.Balance -= amount;
                    Console.WriteLine($"Balance : {Balance}");

                }

            }
            else
            {
                Console.Write("Enter the amount to be deposited : ");
                float amount = float.Parse(Console.ReadLine());
                this.Balance +=amount;
                Console.WriteLine($"Balance : {Balance}");

            }

        }
    }
}
