using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["username"] != null)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ElectricityBillConnectionString1"].ConnectionString);
            conn.Open();
            string name = "Select Name from CT20141221675database where username='" + Request.Cookies["username"].Value + "'";
            SqlCommand namecom = new SqlCommand(name, conn);
            string yourname = namecom.ExecuteScalar().ToString();
            //  TextBox1.Text = "Welcome "+Request.Cookies["username"].Value;
            Name.Visible = true;
            Name.Text = yourname;
           

        }
       
       
        if (RadioButtonList1.SelectedValue.Equals("Commercial"))
        {
            Label1.Text = "Connected Load (Kw)";
            Label1.Visible = true;
            TextBox4.Visible = true;

        }
        else
        {

            Label1.Visible = false;
            TextBox4.Visible = false;
        }

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
       
    }

}