using System;
using System.Data.SqlClient;
using System.Data;
namespace ADOEG
{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        private static void DisconSelectionData()
        {
            con = getCon();
            cmd = new SqlCommand("Select * from cars", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach(DataRow dr in dt.Rows)
            {
                foreach(var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        private static void SelectData()
        {
            con=getCon();
            cmd = new SqlCommand("Select * from cars");
            //cmd = new SqlCommand("Stored procedure name");
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.Write(dr[i] + " ");
                }
                Console.WriteLine();
            }

        }

        private static SqlConnection getCon()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=eurofins;Integrated Security=true");
            con.Open();
            return con;
        }

        private static void InsertData()
        {
            Console.WriteLine("enter values carid,carname,cartype,owner name:");
            string carid = Console.ReadLine();
            string carname = Console.ReadLine();
            string cartype = Console.ReadLine();
            string ownername = Console.ReadLine();

            con = getCon();
            cmd = new SqlCommand("insert into cars values(@car_id,@car_name,@car_type,@owner_name)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@car_id", carid);
            cmd.Parameters.AddWithValue("@car_name", carname);
            cmd.Parameters.AddWithValue("@car_type", cartype);
            cmd.Parameters.AddWithValue("@owner_name", ownername);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i+" number of Row(s) affected");
        }
        static void main(string[] args)
        {
            //SelectData();
            //InsertData();
            //SelectData();
            DisconSelectionData();
        }
    }
}