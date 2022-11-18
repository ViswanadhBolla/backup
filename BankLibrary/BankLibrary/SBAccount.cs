using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankLibrary
{
    public class SBAccount

    {
        public long accountNumber { get; }
        string customerName;
        string customerAdress;
        public float currentBalance { get;  set; }

        public static SqlConnection con;
        public static SqlCommand cmd;

        static long accno = 0;


        private static SqlConnection getCon()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Bank;Integrated Security=true");
            con.Open();
            return con;
        }

        private static void getLastAccNO()
        {
            con = getCon();
            cmd = new SqlCommand("SELECT TOP 1 * FROM accounts ORDER BY accno DESC ");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                accno = (long)dr[0];
            }
            accno += 1;

        }

        public SBAccount()
        {
            getLastAccNO();
            accountNumber = accno;
            accno = accno + 1;
            customerName = "John Doe";
            customerAdress = "adress not found";
            currentBalance = 3000.00f;
        }
        public SBAccount(string customerName,string customerAdress)
        {
            getLastAccNO();
            accountNumber = accno;
            accno = accno + 1;
            CustomerName = customerName;
            CustomerAdress = customerAdress;
            currentBalance = 3000.00f;

        }

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if(value != "")
                {
                    customerName = value;
                }
                else
                {
                    customerName = "John Doe";
                }
            }
        }
        public string CustomerAdress
        {
            get { return customerAdress; }
            set
            {
                if(value != "")
                {
                    customerAdress = value;
                }
                else
                {
                    customerAdress = "Adress not Found";
                }
            }
        }

        public string printDetails()
        {
            return String.Format("Account Number: "+accountNumber
                +"\nCustomer name: "+CustomerName
                +"\nAddress : "+customerAdress
                +"\nBalance: "+currentBalance);
            
        }





    }
}
