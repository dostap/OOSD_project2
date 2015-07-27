// Group        MOHB
// Author:      (Terry) Soktheary Mao, Bade-Adebowale Kehinde
// Description: ContactsAgent's Page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactsAgent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if there is a session with a customerId
        Button buttonLogin = (Button)Master.FindControl("btnLogin");
        Button buttonCustomerInformation = (Button)Master.FindControl("btnCustomerInformation");
        if (Session["customerId"] != null && (int)Session["customerId"] > 0)
        {
            buttonLogin.Text = "Logout"; // display login as logout
            buttonCustomerInformation.Visible = true;
        }
        else
        {
            buttonLogin.Text = "Login"; // display login as login
        }
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {

    }
}