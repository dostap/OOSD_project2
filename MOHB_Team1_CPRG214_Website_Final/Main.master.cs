/*  Author: (Terry) Soktheary Mao, Hazem Hegazy, Bade-Adebowale Kehinde
    Purpose: Checks if there is a session with a customerId 
    associated and redirects to corresponing page
    Date: July 21, 2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // on press of login button if there is no session logout
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (btnLogin.Text == "Login")
        {
            Session["customerId"] = null;
            btnLogin.Text = "Logout";    
        }
        Session.Abandon(); // abandon the session on press of logout
        Server.Transfer("~/Login.aspx");


    }
}
