using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ContentPlaceHolder cp = (ContentPlaceHolder)PreviousPage.Master.FindControl("ContentPlaceHolder1");
        TextBox units;
        TextBox name;
        name = (TextBox)cp.FindControl("Name");

        units = (TextBox)cp.FindControl("TextBox3");
        string unit = units.Text;
        int consumedunits = int.Parse(unit);
        /*TextBox load;
        load = (TextBox)cp.FindControl("TextBox4");
        string load1 = load.Text;
        int connectedload = int.Parse(load1);*/
        RadioButtonList type;
        type = (RadioButtonList)cp.FindControl("RadioButtonList1");
        string typ = type.Text;
        double oldebamount;
        double ebamount;
        int fixedcharges;
        double subsidy;
        double gross;
        int subsfixed = 10;
        double net;
        double tax = 0;
        Label2.Text = "-";
        if (typ == "Domestic")
        {
            if (consumedunits > 0 && consumedunits <= 100)
            {
                oldebamount = consumedunits;
                ebamount = consumedunits * 3;
                fixedcharges = 30;
                gross = ebamount + fixedcharges;
                subsidy = (ebamount - oldebamount);
                net = gross - subsfixed - subsidy;
                Label1.Text = ebamount.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = subsfixed.ToString();
                Label6.Text = subsidy.ToString();
                Label7.Text = net.ToString();

            }
            if (consumedunits > 100 && consumedunits <= 200)
            {
                oldebamount = consumedunits * 1.5;
                ebamount = consumedunits * 3.25;
                fixedcharges = 30;
                gross = ebamount + fixedcharges;
                subsidy = ebamount - oldebamount;
                net = gross - subsfixed - subsidy;
                Label1.Text = ebamount.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = subsfixed.ToString();
                Label6.Text = subsidy.ToString();
                Label7.Text = net.ToString();

            }
            if (consumedunits > 200 && consumedunits <= 500)
            {
                oldebamount = (200 * 2) + (consumedunits - 200) * 3;
                ebamount = (200 * 3.5) + (consumedunits - 200) * 4.6;
                fixedcharges = 30;
                gross = ebamount + fixedcharges;
                subsidy = ebamount - oldebamount;
                net = gross - subsfixed - subsidy;
                Label1.Text = ebamount.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = subsfixed.ToString();
                Label6.Text = subsidy.ToString();
                Label7.Text = net.ToString();

            }
            if (consumedunits > 500)
            {
                oldebamount = (200 * 3) + (300 * 4) + (consumedunits - 500) * 5.75;
                ebamount = (200 * 3.5) + (300 * 4.6) + (consumedunits - 500) * 6.6;
                fixedcharges = 40;
                gross = ebamount + fixedcharges;

                net = gross;
                Label1.Text = ebamount.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = "-";
                Label6.Text = "-";
                Label7.Text = net.ToString();

            }

        }
        if (typ == "Commercial")
        {
            TextBox load;
            load = (TextBox)cp.FindControl("TextBox4");
            string load1 = load.Text;
            int connectedload = int.Parse(load1);
            if (consumedunits > 0 && consumedunits <= 100)
            {
                ebamount = consumedunits * 5;
                tax = 0.05 * ebamount;
                fixedcharges = connectedload * 140;
                gross = ebamount + tax + fixedcharges;
                net = gross;
                Label1.Text = ebamount.ToString();
                Label2.Text = tax.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = "-";
                Label6.Text = "-";
                Label7.Text = net.ToString();
            }
            if (consumedunits > 100)
            {
                ebamount = consumedunits * 8.05;
                tax = 0.05 * ebamount;
                fixedcharges = connectedload * 140;
                gross = ebamount + tax + fixedcharges;
                net = gross;
                Label1.Text = ebamount.ToString();
                Label2.Text = tax.ToString();
                Label3.Text = fixedcharges.ToString();
                Label4.Text = gross.ToString();
                Label5.Text = "-";
                Label6.Text = "-";
                Label7.Text = net.ToString();

            }


        }
    }
}