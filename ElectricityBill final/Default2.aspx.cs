using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ElectricityBillConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("insert into CT20141221675database values('" + TextBox2.Text + "','" + TextBox1.Text + "','"+TextBox5.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"')", conn);
        com.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
        Label1.Visible = true;
        Label1.Text = "Congratulations Registration Sucessfull";
        Response.AddHeader("REFRESH", "5;URL=Default.aspx");
    }
}