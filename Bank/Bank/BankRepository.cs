using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
using BankDBmanagement;
using System.Data.SqlClient;
using System.Reflection;


namespace Bank
{
    internal class BankRepository : IBankRepository
    {
        static List<SBAccount> accounts = new List<SBAccount>();
        static List<SBTransactioncs> transactions = new List<SBTransactioncs>();
        static accountsTable AT = new accountsTable();
        static SqlDataReader DR;


        public void PrintDataReader(SqlDataReader dr)
        {
            int count = 0;

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.Write(dr[i] + " ");
                }
                Console.WriteLine();
                count += 1;
            }
            if (count < 1)
            {
                Console.WriteLine("No record(s) found.");
            }
        }
        #region
        public void NewAccount(SBAccount acc)
        {
            accounts.Add(acc);

        }

        public SBAccount GetAccountDetails(long accno)
        {
            SBAccount pointer = null;
            foreach (SBAccount acc in accounts)
            {
                if (acc.accountNumber == accno)
                {
                    pointer = acc;
                    break;
                }

            }
            if (pointer == null)
            {
                throw new AccountNotFoundException("Account not found.\n----------------------------------------");
            }
            return pointer;

        }

        public List<SBAccount> GetAllAccounts()
        {
            return accounts;
        }

        public void DepositAmount(long accno, float amt)
        {
            SBAccount pointer = null;
            foreach (SBAccount acc in accounts)
            {
                if (acc.accountNumber == accno)
                {
                    pointer = acc;
                    break;
                }
            }

            SBTransactioncs transaction = new SBTransactioncs(pointer.accountNumber, amt);
            transactions.Add(transaction);
            pointer.currentBalance += amt;

        }

        public void WithdrawAmount(long accno, float amt)
        {

            SBAccount pointer = null;
            foreach (SBAccount acc in accounts)
            {
                if (acc.accountNumber == accno)
                {
                    pointer = acc;
                    break;
                }
            }

            if (pointer.currentBalance >= amt)
            {
                SBTransactioncs transaction = new SBTransactioncs(pointer.accountNumber, -1 * amt);
                transactions.Add(transaction);
                pointer.currentBalance -= amt;
            }
            else
            {
                Console.WriteLine(" Ammount is insufficient");
            }


        }

        public List<SBTransactioncs> GetAllTransactions(long accno)
        {
            List<SBTransactioncs> requiredTransactions
                = new List<SBTransactioncs>();

            foreach (SBTransactioncs transaction in transactions)
            {
                if (transaction.accountNumber == accno)
                {
                    requiredTransactions.Add(transaction);
                }
            }
            return requiredTransactions;
        }
        #endregion


        public static void Main(string[] args)
        {
            #region
            //SBAccount sBAccount = new SBAccount("viswa","padur");
            //SBAccount sBAccount1 = new SBAccount("purush", "kelambakkam");
            //BankRepository bankRepository = new BankRepository();

            ////new account
            //bankRepository.NewAccount(sBAccount);
            //bankRepository.NewAccount(sBAccount1);

            ////getAccountdetails
            //SBAccount temp = bankRepository.GetAccountDetails(sBAccount.accountNumber);
            //if(temp != null)
            //{
            //    Console.WriteLine(temp.printDetails());
            //}
            //else
            //{
            //    Console.WriteLine("account not found");
            //}

            //Console.WriteLine("==================================================");

            ////getallAccounts
            //List<SBAccount> temp1 = bankRepository.GetAllAccounts();
            //foreach(SBAccount item in temp1)
            //{
            //    Console.WriteLine(item.printDetails());
            //}
            //Console.WriteLine("==================================================");

            ////depositAmount
            //bankRepository.DepositAmount(sBAccount.accountNumber, 5000.00f);
            //temp = bankRepository.GetAccountDetails(sBAccount.accountNumber);
            //Console.WriteLine(temp.printDetails());
            //Console.WriteLine("==================================================");

            ////withdrawl ammount
            //bankRepository.WithdrawAmount(sBAccount.accountNumber, 3000.00f);
            //temp = bankRepository.GetAccountDetails(sBAccount.accountNumber);
            //Console.WriteLine(temp.printDetails());
            //Console.WriteLine("==================================================");

            ////getall transactions
            //List<SBTransactioncs> temp2 = bankRepository.GetAllTransactions(sBAccount.accountNumber);
            //foreach(SBTransactioncs item in temp2)
            //{
            //    Console.WriteLine(item.printDetails());
            //    Console.WriteLine("----------------------------------------------");
            //}
            //Console.WriteLine("==================================================");
            #endregion
            BankRepository BR = new BankRepository();
            Console.WriteLine("Welcome to SB bank Interface");
            Console.WriteLine("============================");
            while (true)
            {
                Console.WriteLine("press 1 for Admin\npress 2 for account holder\nPress 3 to quit");
                string user = Console.ReadLine();

                //Admin
                if (user == "1")
                {
                    Console.WriteLine("Admin");
                    Console.WriteLine("----------");
                    bool flag1 = true;

                    while (flag1)
                    {
                        Console.WriteLine("Choose an option \n1.Create an account.\n2.print account details.\n3.get all the accounts' details\n4.Get transaction details of an account.\n5.Exit");
                        int choice = 0;
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                //create an account
                                Console.Write("enter user name: ");
                                string name = Console.ReadLine();
                                Console.Write("enter user adress: ");
                                string adress = Console.ReadLine();
                                Console.WriteLine("----------------------");
                                SBAccount account = new SBAccount(name, adress);
                                AT.inserdata(account); ;
                                Console.WriteLine(account.printDetails());
                                Console.WriteLine("------------------------------");
                                break;
                            case 2:
                                // print an account details
                                Console.Write("enter account number: ");
                                long accno = 0;
                                long.TryParse(Console.ReadLine(), out accno);
                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno);
                                //    Console.WriteLine(temp.printDetails());
                                //}
                                //catch (AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                DR = accountsTable.getAccountDetails(accno);
                                BR.PrintDataReader(DR);

                                break;
                            case 3:
                                //print all account details
                                #region
                                //List<SBAccount> accs = BR.GetAllAccounts();
                                //if (accs.Count > 0)
                                //{
                                //    foreach (SBAccount sBAccount in accs)
                                //    {
                                //        Console.WriteLine(sBAccount.printDetails());
                                //        Console.WriteLine("----------------------------------------");
                                //    }
                                //}
                                //else
                                //{
                                //    Console.WriteLine("no accounts in the database.");
                                //    Console.WriteLine("----------------------------------------");
                                //}
                                #endregion
                                DR = AT.getAllAccountDetails();
                                DR.Read();
                                BR.PrintDataReader(DR);
                                break;
                            case 4:
                                //get transaction details of an account
                                Console.Write("Enter the account number: ");
                                long accno1 = 0;
                                long.TryParse(Console.ReadLine(), out accno1);
                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno1);
                                //    List<SBTransactioncs> tran = BR.GetAllTransactions(accno1);
                                //    if (tran.Count > 0)
                                //    {
                                //        foreach (SBTransactioncs sBTransactioncs in tran)
                                //        {
                                //            Console.WriteLine(sBTransactioncs.printDetails());
                                //            Console.WriteLine("----------------------------------------");
                                //        }
                                //    }
                                //    else
                                //    {
                                //        Console.WriteLine("No transactions found for this account");
                                //        Console.WriteLine("----------------------------------------");
                                //    }
                                //}
                                //catch(AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                DR = accountsTable.transactionDetails(accno1);
                                BR.PrintDataReader(DR);
                                break;
                            case 5:
                                flag1 = false;
                                break;
                            default:
                                break;

                        }
                    }
                }

                //customer
                else if (user == "2")
                {
                    Console.WriteLine("Account holder");
                    Console.WriteLine("-----------------");
                    bool flag1 = true;
                    while (flag1)
                    {
                        Console.WriteLine("Choose an option \n1.Check balance.\n2.deposit.\n3.withdrawl\n4.mini statemtnt.\n5.Exit");
                        int choice = 0;
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                //Check balance.
                                Console.Write("Enter account number : ");
                                long accno = 0;
                                long.TryParse(Console.ReadLine(), out accno);
                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno);
                                //    Console.WriteLine(temp.printDetails());
                                //}
                                //catch (AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                DR = accountsTable.getAccountDetails(accno);
                                BR.PrintDataReader(DR);
                                break;
                            case 2:
                                //deposit
                                Console.Write("Enter account number : ");
                                long accno1 = 0;
                                long.TryParse(Console.ReadLine(), out accno1);
                                Console.Write("Enter the ammount : ");
                                float amountDeposit = float.Parse(Console.ReadLine());
                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno1);
                                //    BR.DepositAmount(accno1, amountDeposit);
                                //    Console.WriteLine(temp.printDetails());
                                //}
                                //catch (AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                SBTransactioncs deposit = new SBTransactioncs(accno1, amountDeposit);
                                Console.WriteLine(AT.DepositMoney(deposit));

                                break;
                            case 3:
                                //withdrawl
                                Console.Write("Enter account number : ");
                                long accno2 = 0;
                                long.TryParse(Console.ReadLine(), out accno2);
                                Console.Write("Enter the ammount : ");
                                float amountwithdraw = float.Parse(Console.ReadLine());
                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno2);
                                //    BR.WithdrawAmount(accno2, amountwithdraw);
                                //    Console.WriteLine(temp.printDetails());
                                //}
                                //catch (AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                SBTransactioncs withdraw = new SBTransactioncs(accno2, -1*amountwithdraw);
                                Console.WriteLine(AT.WithDrawMoney(withdraw));
                                break;
                            case 4:
                                //mini statemtnt.
                                Console.Write("Enter the account number: ");
                                long accno3 = 0;
                                long.TryParse(Console.ReadLine(), out accno3);

                                #region
                                //try
                                //{
                                //    SBAccount temp = BR.GetAccountDetails(accno3);
                                //    List<SBTransactioncs> tran = BR.GetAllTransactions(accno3);
                                //    if (tran.Count > 0)
                                //    {
                                //        foreach (SBTransactioncs sBTransactioncs in tran)
                                //        {
                                //            Console.WriteLine(sBTransactioncs.printDetails());
                                //            Console.WriteLine("----------------------------------------");
                                //        }
                                //    }
                                //    else
                                //    {
                                //        Console.WriteLine("No transactions found for this account.");
                                //        Console.WriteLine("----------------------------------------");
                                //    }
                                //}
                                //catch (AccountNotFoundException e)
                                //{
                                //    Console.WriteLine(e.Message);
                                //}
                                #endregion
                                DR=accountsTable.transactionDetails(accno3);
                                BR.PrintDataReader(DR);
                                break;
                            case 5:
                                //exit
                                flag1 = false;
                                break;
                            default:
                                break;
                        }


                    }

                }

                //close app
                else if (user == "3")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid coice");
                }
            }

            Console.WriteLine("***************Thankyou******************");



        }
    }
}
