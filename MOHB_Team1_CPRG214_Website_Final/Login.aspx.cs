/*  Author: (Terry) Soktheary Mao, Hazem Hegazy, Bade-Adebowale Kehinde
    Purpose: Checks if there is a session with a customerId 
    associated and redirects to corresponing page
    Date: July 21, 2015
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // on click of the login button call the AutheticateUser method to check if username & password exist and match
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int custID = CustomerDB.AuthenticateUser(txtCustUserName.Text, txtCustPassword.Text);
        if (custID > 0)
        {
            Session["customerId"] = custID; // session is assocaciated with a customerID attached to username 
            Response.Redirect("~/CustomerPackages.aspx"); // redirect to corresponing page

        }
        else
            lblError.Text = "Incorrect Username or Password. Please try again.";
    }
}