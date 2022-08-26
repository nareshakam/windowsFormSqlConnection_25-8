using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace customer
{
    public partial class CustmerRegistration : Form
    {
        //for Accesing diffrent form class
        String custName = "";
        String sex = "";
        String hobbies = "";
        String Status = "";
        String cuntry = "";
        //
        public CustmerRegistration()
        {
            InitializeComponent();
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
           
        CommonCode cd = new CommonCode();

            custName = txtName.Text;
            //String custId = txtCustID.Text;
            if (cd.namevalidation(txtName.Text) == false)
            {
                MessageBox.Show("Custmer name Invalied....!");
                return;
            }
            sex = "";
            hobbies = "";
            Status = "";
            if(radioMarried.Checked)
            {
                Status = "Married";
            }
            else if(radioUnmarried.Checked)
            {
                Status = "UnMarried";
            }
            if(checkPainting.Checked&&checkReading.Checked)
            {
                hobbies = "reading,Painting";
            }
            else if(checkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else if(checkReading.Checked)
            {
                hobbies = "Reading";
            }
            if(radioMale.Checked)
            {
                sex = "Male";
            }
            else if(radiofemale.Checked)
            {
                sex = "Female";
            }
            cuntry = "";//own Adding to Handile the Exception start 1
            if(cmbCuntry.SelectedValue==null)
            {
                cuntry = cmbCuntry.Text;
            }
            else
            {
                cuntry =cmbCuntry.SelectedValue.ToString();
            }//end 1
            if(cuntry.Length==0)
            {
                MessageBox.Show("please Select The Cuntry....!");
                return;
            }
            if(sex.Length==0)
            {
                MessageBox.Show("please Select The gender..!");
                return;
            }
            if (Status.Length == 0)
            {
                MessageBox.Show("please Select The marital Status ..!");
                return;
            }
            if(hobbies.Length==0)
            {
                MessageBox.Show("please Select The hobbies..!");
                return;
            }
            CustmerPreview cp = new CustmerPreview();
            cp.setValues(txtName.Text, cuntry, sex,hobbies,Status);
            cp.ShowDialog();
        }

        private void CustmerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void radioUnmarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCuntry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gBsex_Enter(object sender, EventArgs e)
        {

        }

        private void checkReading_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkPainting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
