/*  Author: (Terry) Soktheary Mao
    Purpose: Checks if Session is active
    Date: July 21, 2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    // on page load checks if there is a session active
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
}