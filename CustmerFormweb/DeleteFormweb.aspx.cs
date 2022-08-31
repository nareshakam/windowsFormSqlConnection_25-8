using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using DataConnect;

namespace CustmerFormweb
{
    public partial class DeleteFormweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadCustmers();
        }

        private void loadCustmers()
        {
            clSqlServer css = new clSqlServer();
            GridView1.DataSource = css.getCustomers();
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearScrean()
        {
            txtDltIDData.Text = "";
            txtDltNameData.Text = "";
        }
        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = txtDltNameData.Text;
            string id = txtDltIDData.Text;

            string query = "Delete from myCust Where CustmerName = '" + name + "' and Id = '"+id+"'";
            clSqlServer css = new clSqlServer();
            int a = css.getCustomers(query);
            if(a>0)
            {
                Response.Write("<script>alert('Deleted')</Script>");
                loadCustmers();
                ClearScrean();
            }
        }
    }
}