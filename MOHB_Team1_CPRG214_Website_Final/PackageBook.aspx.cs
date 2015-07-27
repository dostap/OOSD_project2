/* 
 * This is the package booking page which enables the customer to book a package
 * Author: Hazem Hegazy
 * Date: Jul-2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PackageBook : System.Web.UI.Page
{
    private int pkgId; // declare package id variable
    private int custId; // declare customer id variable

    protected void Page_Load(object sender, EventArgs e)
    {
        ////// for testing purposes
        //Session["pkgId"] = 2;
        //Session["customerId"] = 104;

        pkgId = Convert.ToInt32(Session["packageId"]); // accepting the package id from the session coming from the packages page
        custId = Convert.ToInt32(Session["customerId"]);  // accepting the customer id from the session created on the customer login

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

        // if there is no session deny access to the page redirect to Missing404 page
        if (Session["customerId"] == null)
        {

            Response.Redirect("~/Missing404.aspx");
        }

        

    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        // call method to book the chosen package for the logged customer
        string bookNo = BookPackageDB.BookPackageToCustomer(custId, pkgId, Convert.ToInt32(txtTravelerCount.Text));
        if (bookNo != null) // if booked successfully
        {
            lblSaveStatus.ForeColor = System.Drawing.Color.Green; // color the message with green
            lblSaveStatus.Text = "Package has been successfull booked. Your booking number is " + bookNo ; // display success message
            btnViewPackages.Visible = true;
        }
        else // if failed to book
        {
            lblSaveStatus.ForeColor = System.Drawing.Color.Red; // color the message with red
            lblSaveStatus.Text = "Saving failed, please try again"; // display failure message
        }
        
    }
    // on click of view packages go to customer page
    protected void btnPackages_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CustomerPackages.aspx");
    }
}