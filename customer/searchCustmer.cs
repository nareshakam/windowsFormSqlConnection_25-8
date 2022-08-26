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
    public partial class searchCustmer : Form
    {
        public searchCustmer()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
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
                //3.Bind The data To UI
                dataGridViewSearch.DataSource = ds.Tables[0];
                //Close the connection
                conn.Close();
        }
        ////create the object for the common codeclass to validate the name
        //CommonCode cd = new CommonCode();

        //if(cd.namevalidation(txtSearchCustmer.Text)==false)
        //{
        //    MessageBox.Show("CustmerName Required..!");
        //    return;
        //}
    }
}
