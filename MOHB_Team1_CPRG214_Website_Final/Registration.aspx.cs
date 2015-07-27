/*  Author: (Terry) Soktheary Mao, Hazem Hegazy
    Purpose: Checks if Session is active and validates registration inputs
    Date: July 21, 2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    // on page load check whether there is a session
    protected void Page_Load(object sender, EventArgs e)
    {
        // change button login to logout or vice-versa depending on session
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
    // on click of register button checks if a username already exists
    // give appropriate error and confirmation messages
    protected void InsertButton_Click(object sender, EventArgs e)
    {
        TextBox text1 = (TextBox)fvRegistration.FindControl("CustUserNameTextBox");
        if (CustomerDB.CheckCustUserName(text1.Text))
        {
            lblError.Text = "This Username already exists. Please choose another Username.";
            lblError.ForeColor = System.Drawing.Color.Red;
            return;
        }
        if (Page.IsValid)
        {
            lblError.Text = "You have successfully Registered! Please proceed to the login page.";
            lblError.ForeColor = System.Drawing.Color.Green;
        }
    }
}