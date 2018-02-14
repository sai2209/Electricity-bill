using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default6 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ElectricityBillConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // string emailcheck = TextBox1.Text;
        string checkcustomerid = "Select count (*) from CT20141221675database where CustomerId='" + TextBox1.Text + "'";
        SqlCommand com = new SqlCommand(checkcustomerid, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
       // conn.Close();
        if (temp == 1)
        {
            if (TextBox2.Text == TextBox3.Text)
            {
                
                SqlCommand updatepass = new SqlCommand("update CT20141221675database set Password='" + TextBox2.Text + "' where CustomerId='" + TextBox1.Text + "'", conn);
                updatepass.ExecuteNonQuery();
                  conn.Close();
                GridView1.DataBind();
                Label1.Visible = true;
                Label1.Text = "Password Sucessfully Changed";
                Response.AddHeader("REFRESH", "5;URL=Default.aspx");
                
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Passwords do not Match";
            }
        }
        else
        {
            Label1.Text = "Customer_Id do not exist";
        }
    }
}