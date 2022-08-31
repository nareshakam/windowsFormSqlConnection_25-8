using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace DataConnect
{
    public class clSqlServer
    {
        public DataSet getCustomers()
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object

            SqlCommand cmd = new SqlCommand("select * from myCust", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public DataSet getCustomers(int CustmerCode)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object

            SqlCommand cmd = new SqlCommand("select * from myCust where Id ='" + CustmerCode + "'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public int getCustomers(String Query)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object

            SqlCommand cmd = new SqlCommand(Query, conn);
            int a = cmd.ExecuteNonQuery();
            //Close the connection
            conn.Close();
            return a;
        }
    }
}
