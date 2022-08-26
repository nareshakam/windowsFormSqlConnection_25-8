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
    public partial class CustmerPreview : Form
    {
        public CustmerPreview()
        {
            InitializeComponent();
        }
        public void setValues(String CustmerName,String cuntry,String sex,String hobbies,String Status)
        {
            
            NameData.Text = CustmerName;
            CuntryData.Text = cuntry;
            sexData.Text = sex;
            HobbyData.Text = hobbies;
            StatusData.Text = Status;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CustmerPreview cp = new CustmerPreview();
            cp.Close();
            CustmerRegistration cr = new CustmerRegistration();
            cr.ShowDialog();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Ado.net Code to Connect the sql with winform
            //1.open Connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            //2.fire the insert command

            String CustName = NameData.Text;
            String Cuntry = CuntryData.Text;
            String Hobbies = HobbyData.Text;
            String Gender = sexData.Text;
            String Status = StatusData.Text;
           // int Id = Convert.ToInt32(CustIdData.Text);

            String query = "insert into myCust values('"+ CustName + "','" 
                                                       + Cuntry + "','" 
                                                       + Gender + "','" 
                                                       + Hobbies + "','" 
                                                        + Status+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("Inserted Successfully....!");
                
            }
            else
            {
                MessageBox.Show("Insertion faild....!");
               
            }
            //3.close the connection
            conn.Close();
        }
    }
}
