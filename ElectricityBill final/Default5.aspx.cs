using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}