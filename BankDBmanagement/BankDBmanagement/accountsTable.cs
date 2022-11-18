using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

namespace BankDBmanagement
{
    public class accountsTable
    {
        public static SqlConnection con;
        public static SqlCommand cmd;



        private static SqlConnection getCon()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Bank;Integrated Security=true");
            con.Open();
            return con;
        }

        public void inserdata(SBAccount sba)
        {
            con = getCon();
            cmd = new SqlCommand("insert into accounts values(@accno,@cname,@caddress,@balance)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@accno", sba.accountNumber);
            cmd.Parameters.AddWithValue("@cname", sba.CustomerName);
            cmd.Parameters.AddWithValue("@caddress", sba.CustomerAdress);
            cmd.Parameters.AddWithValue("@balance", sba.currentBalance);
            int i = cmd.ExecuteNonQuery();

        }

        public static SqlDataReader getAccountDetails(long accnum)
        {
            con = getCon();
            cmd = new SqlCommand("select * from accounts where accno = " + accnum);
            cmd.Connection = con;
            SqlDataReader DR = cmd.ExecuteReader();
            return DR;
        }

        public SqlDataReader getAllAccountDetails()
        {
            con = getCon();
            cmd = new SqlCommand("select * from accounts ");
            cmd.Connection = con;
            SqlDataReader DR = cmd.ExecuteReader();
            return DR;
        }

        private static void updateBalance(long accno, float amt)
        {
            con = getCon();
            cmd = new SqlCommand("update accounts set balance = balance +" + amt + " where accno = " + accno, con);
            int i = cmd.ExecuteNonQuery();
        }

        public string DepositMoney(SBTransactioncs transaction)
        {

            SqlDataReader tempacc = getAccountDetails(transaction.accountNumber);
            bool flag = false;
            while (tempacc.Read())
            {
                con = getCon();
                cmd = new SqlCommand("insert into transactions values(@transID,@accno,@transamnt,@transDate,@transtype)", con);
                cmd.Parameters.AddWithValue("@transID", transaction.transactionId);
                cmd.Parameters.AddWithValue("@accno", transaction.accountNumber);
                cmd.Parameters.AddWithValue("@transamnt", transaction.amount);
                cmd.Parameters.AddWithValue("@transDate", transaction.transactionDate);
                cmd.Parameters.AddWithValue("@transtype", transaction.TransactionType);
                int i = cmd.ExecuteNonQuery();
                updateBalance(transaction.accountNumber, transaction.amount);
                flag = true;

            }
            if (flag)
            {
                return ("transaction Done");
            }
            else
            {
                return ("Account not found");
            }
        }

        public string WithDrawMoney(SBTransactioncs transaction)
        {

            SqlDataReader tempacc = getAccountDetails(transaction.accountNumber);

            bool flag = false;
            while (tempacc.Read())
            {
                if ((decimal)tempacc[3] < (decimal)transaction.amount)
                {
                    
                    return ("ammount not sufficient");
                }
                con = getCon();
                cmd = new SqlCommand("insert into transactions values(@transID,@accno,@transamnt,@transDate,@transtype)", con);
                cmd.Parameters.AddWithValue("@transID", transaction.transactionId);
                cmd.Parameters.AddWithValue("@accno", transaction.accountNumber);
                cmd.Parameters.AddWithValue("@transamnt", transaction.amount);
                cmd.Parameters.AddWithValue("@transDate", transaction.transactionDate);
                cmd.Parameters.AddWithValue("@transtype", transaction.TransactionType);
                int i = cmd.ExecuteNonQuery();
                updateBalance(transaction.accountNumber, -1*transaction.amount);
                flag = true;

            }
            if (flag)
            {
                return ("transaction Done");
            }
            else
            {
                return ("Account not found");
            }
        }

        public static SqlDataReader transactionDetails(long accnum)
        {
            con = getCon();
            cmd = new SqlCommand("select * from transactions where accno = " + accnum);
            cmd.Connection = con;
            SqlDataReader DR = cmd.ExecuteReader();
            return DR;
        }
    }
}
