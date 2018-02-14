using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ElectricityBillConnectionString1"].ConnectionString);
        conn.Open();
        string checkuser = "Select count (*) from CT20141221675database where username='" + TextBox1.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string checkpassword = "Select Password from CT20141221675database where username='" + TextBox1.Text + "'";
            SqlCommand passcom = new SqlCommand(checkpassword, conn);
            string Password = passcom.ExecuteScalar().ToString();
            if (Password == TextBox2.Text)
            {
                Response.Cookies["username"].Value = TextBox1.Text;
                Response.Redirect("Default3.aspx");
                Session["New"] = TextBox1.Text;
                Button1.PostBackUrl = "~/Default3.aspx";

            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = true;
                Label2.Text="Password is incorrect";
                
            }

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "User id doesnot exist";
            
        }
    }
}