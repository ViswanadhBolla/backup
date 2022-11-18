using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOEG
{
    internal class lastAccount
    {
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
            //cmd = new SqlCommand("Select * from accounts");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            //long.TryParse((string?)dr[0], out accno);
            while (dr.Read())
            {

                accno = (long)dr[0];

            }

            Console.WriteLine(accno);


        }

        public static void main(string[] args)
        {
            getLastAccNO();
        }
    }
}
