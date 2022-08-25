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
        public CustmerRegistration()
        {
            InitializeComponent();
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
           
        CommonCode cd = new CommonCode();

            if (cd.namevalidation(txtName.Text) == false)
            {
                MessageBox.Show("Custmer name Invalied....!");
                return;
            }
            String sex = "";
            String hobbies = "";
            String Status = "";
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
            String cuntry = "";//own Adding to Handile the Exception start 1
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

        private void checkReading_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
