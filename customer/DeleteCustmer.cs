using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace customer
{
    public partial class DeleteCustmer : Form
    {
        public DeleteCustmer()
        {
            InitializeComponent();
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteCustmer_Load(object sender, EventArgs e)
        {
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object

            SqlCommand cmd = new SqlCommand("select * from myCust", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            //3.Bind The data To UI
            dtGrid.DataSource = ds.Tables[0];
            //Close the connection
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // here we delete the record

            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            String Custname = dltCustNameData.Text;   
            if(Custname.Length==0)
            {
                MessageBox.Show("Custmer name mandetary...!");
                return;
            }
            String custid = dltCustIdData.Text;
            if (custid.Length == 0)
            {
                MessageBox.Show("Custmer Id mandetary...!");
                return;
            }
            String query = "DELETE FROM myCust WHERE CustmerName = '"+Custname+"' and Id = "+Convert.ToInt32(custid)+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            
            if(a>0)
            {
                MessageBox.Show("deleted Succesfully...!");
            }
            else
            {
                MessageBox.Show("opps try again... Faild...!");
            }
            //Close the connection
            conn.Close();
        }

       /* private void dtg_CustmerRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //we will get the custmer Code here
            //in selected
            String strSelectedCustmer = dtGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e.rowindex gets the selectes row
            //zero th cell gets the custmer code
            DisplyCustmer(strSelectedCustmer);

        }
        private void DisplyCustmer(String CustmerCode)
        {
            //Select the Custmer And displays the same on the screen
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            SqlCommand cmd = new SqlCommand("select * from myCust", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            ////3.Bind The data To UI
            //String strCutmerName = ds.Tables[0].Rows[0][0].ToString();
            //String strCuntry = ds.Tables[0].Rows[0][1].ToString();
            //String strGender = ds.Tables[0].Rows[0][2].ToString();
            //String strhobbis = ds.Tables[0].Rows[0][3].ToString();
            //String strStatus = ds.Tables[0].Rows[0][4].ToString();
            //CustmerRegistration cr = new CustmerRegistration();
            
            //Close the connection
            conn.Close();
        }*/
    }
}
