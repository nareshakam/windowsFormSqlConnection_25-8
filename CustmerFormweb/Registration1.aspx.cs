using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnect;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CustmerFormweb
{
    public partial class Registration1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            loadCustmers();
            
        }
        private void loadCustmers()
        {
            clSqlServer css = new clSqlServer();
            CustGridview1.DataSource = css.getCustomers();
            CustGridview1.DataBind();
        }
        public void ClearScreen()
        {
            txtCustmerNameData.Text = "";
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            CheckPainting.Checked = false;
            CheckReading.Checked = false;
            RadioMarried.Checked = false;
            RadioUnmarried.Checked = false;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtCustmerNameData.Text;
            if (txtCustmerNameData.Text.Length == 0)
            {
                Response.Redirect("<script>alert('Custmer name should not empty')</script>");
                return;
            }
            string Country = ddlCountry.SelectedValue.ToString();
            string gender = "";
            string hobbies = "";
            string status = "";
            if(RadioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if(CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            if(RadioMarried.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "UnMarried";
            }
            string query = "insert into myCust Values('"+name+ "','" + Country + "','" + gender + "','" + hobbies + "','" + status + "')";
            clSqlServer css = new clSqlServer();
            css.getCustomers(query);
            loadCustmers();
            ClearScreen();
        }

        protected void BtnUpDate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CustGridview1.Rows[CustGridview1.SelectedIndex].Cells[1].Text);
            string name = txtCustmerNameData.Text;
            string Country = ddlCountry.SelectedValue.ToString();
            string gender = "";
            string hobbies = "";
            string status = "";
            if (RadioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            if (RadioMarried.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "UnMarried";
            }
            string query = "update myCust set CustmerName ='"+name+"',Cuntry = '"+Country+"',Gender = '"+gender+"',Hobbies = '"+hobbies+"',Status = '"+status+"' Where Id = "+id+" or CustmerName = '"+name+"'";
            clSqlServer css = new clSqlServer();
            int a = css.getCustomers(query);
            if(a>0)
            {
                Response.Write("<script>alert('Updated')</Script>");
            }
            else
            {
                Response.Write("<script>alert('Failed')</Script>");
            }
            ClearScreen();
            loadCustmers();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int refId = Convert.ToInt32(CustGridview1.Rows[CustGridview1.SelectedIndex].Cells[1].Text);
            if (refId == 0)
            {
                Response.Redirect("DeleteFormweb.aspx");
            }
            else
            {
                string name = txtCustmerNameData.Text;
                string Country = ddlCountry.SelectedValue.ToString();
                string gender = "";
                string hobbies = "";
                string status = "";
                if (RadioMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                if (CheckPainting.Checked)
                {
                    hobbies = "Painting";
                }
                else
                {
                    hobbies = "Reading";
                }
                if (RadioMarried.Checked)
                {
                    status = "Married";
                }
                else
                {
                    status = "UnMarried";
                }
                string query = "Delete from myCust Where CustmerName = '" + name + "' and Id = "+refId+"";
                clSqlServer css = new clSqlServer();
                css.getCustomers(query);
                ClearScreen();
                loadCustmers();
            }
        }
        private void DisplyCustmer(int CustmerCode)
        {
            //Cetralize the code to reduce the code redendance
            clSqlServer css = new clSqlServer();
            DataSet ds = css.getCustomers(CustmerCode);

            //3.Bind The data To UI
            int RefId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            string strCutmerName = ds.Tables[0].Rows[0][1].ToString();
            string strCuntry = ds.Tables[0].Rows[0][2].ToString();
            string strGender = ds.Tables[0].Rows[0][3].ToString();
            string strhobbis = ds.Tables[0].Rows[0][4].ToString();
            string strStatus = ds.Tables[0].Rows[0][5].ToString();

            txtCustmerNameData.Text = strCutmerName;
            ddlCountry.SelectedValue = strCuntry;
            if (strGender == "Male")
            {
                RadioMale.Checked = true;
            }
            else if (strGender == "Female")
            {
                RadioFemale.Checked = true;
            }
            if (strhobbis == "Reading")
            {
                CheckReading.Checked = true;
            }
            else if (strhobbis == "Painting")
            {
                CheckPainting.Checked = true;
            }
            if (strStatus == "Married   ")
            {
                RadioMarried.Checked = true;
            }
            else if (strStatus == "UnMarried ")
            {
                RadioUnmarried.Checked = true;
            }

        }
        protected void CustGridview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrive the selected value by using the index
            //clear the screen
            ClearScreen();
            int refId = Convert.ToInt32(CustGridview1.Rows[CustGridview1.SelectedIndex].Cells[1].Text);
            DisplyCustmer(refId);
            
        }
    }
}