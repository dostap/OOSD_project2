/**Date: July 18, 2015
    Author: Darya Ostapenko
    Project: OOSD Project 2
    **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VacationPackages : System.Web.UI.Page
{
    // Terry revised on Page_Load method to handle customer sessions
    protected void Page_Load(object sender, EventArgs e)
    {
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
    //on click of the vacation package image button
    //assign session variable
    // show form view with hthe package details
    //make sure the Book Now button is visible for this particular package
    //make sure the other buttons are disables
    //same logic for all packages
    protected void imgPkg1_Click(object sender, ImageClickEventArgs e)
    {
        Session["packageId"] = 1;

        FormViewPkg1.Visible = true;
        FormViewPkg2.Visible = false;
        FormViewPkg3.Visible = false;
        FormViewPkg4.Visible = false;

        btnBookPkg1.Visible = true;
        btnBookPkg2.Visible = false;
        btnBookPkg3.Visible = false;
        btnBookPkg4.Visible = false;

        ResetErrorMsgs();

        lblError.Visible = false;
    }

    protected void imgPkg2_Click(object sender, ImageClickEventArgs e)
    {
        Session["packageId"] = 2;

        FormViewPkg1.Visible = false;
        FormViewPkg2.Visible = true;
        FormViewPkg3.Visible = false;
        FormViewPkg4.Visible = false;

        btnBookPkg1.Visible = false;
        btnBookPkg2.Visible = true;
        btnBookPkg3.Visible = false;
        btnBookPkg4.Visible = false;

        ResetErrorMsgs();

        lblError.Visible = false;
    }
    protected void imgPkg3_Click(object sender, ImageClickEventArgs e)
    {
        Session["packageId"] = 3;

        FormViewPkg1.Visible = false;
        FormViewPkg2.Visible = false;
        FormViewPkg3.Visible = true;
        FormViewPkg4.Visible = false;

        btnBookPkg1.Visible = false;
        btnBookPkg2.Visible = false;
        btnBookPkg3.Visible = true;
        btnBookPkg4.Visible = false;

        ResetErrorMsgs();

        lblError.Visible = false;
    }
    protected void imgPkg4_Click(object sender, ImageClickEventArgs e)
    {
        Session["packageId"] = 4;

        FormViewPkg1.Visible = false;
        FormViewPkg2.Visible = false;
        FormViewPkg3.Visible = false;
        FormViewPkg4.Visible = true;

        btnBookPkg1.Visible = false;
        btnBookPkg2.Visible = false;
        btnBookPkg3.Visible = false;
        btnBookPkg4.Visible = true;

        ResetErrorMsgs();

        lblError.Visible = false;
    }

    //ook now button - assign session variable
    //transfer to bookings page
    protected void btnBookPkg1_Click(object sender, EventArgs e)
    {
        if (Session["customerId"] != null && (int)Session["customerId"] > 0)
        {
            
            Session["packageId"] = 1;
            Response.Redirect("~/PackageBook.aspx");
        }
        else
        {
            lblError.Visible = true;
        }
        
    }
    protected void btnBookPkg2_Click(object sender, EventArgs e)
    {

        if (Session["customerId"] != null && (int)Session["customerId"] > 0)
        {

            Session["packageId"] = 2;
            Server.Transfer("~/PackageBook.aspx");
        }
        else
        {
            lblError.Visible = true;
        }
    }
    protected void btnBookPkg3_Click(object sender, EventArgs e)
    {
        if (Session["customerId"] != null && (int)Session["customerId"] > 0)
        {

            Session["packageId"] = 3;
            Server.Transfer("~/PackageBook.aspx");
        }
        else
        {
            lblError.Visible = true;
        }
    }
    protected void btnBookPkg4_Click(object sender, EventArgs e)
    {

        if (Session["customerId"] != null && (int)Session["customerId"] > 0)
        {

            Session["packageId"] = 4;
            Server.Transfer("~/PackageBook.aspx");
        }
        else
        {
            lblError.Visible = true;
        }
    }

    protected void FormViewPkg1_DataBound(object sender, EventArgs e)
    {
       //call the CheckDates method to see if the dates are valid
        FormView currentForm;
        currentForm = FormViewPkg1;
        //declare a bool to keep track if the dates are valid
        bool validDates = true;
        validDates = CheckDates(currentForm);
        if (validDates == false)
        {
            //if dates are not valid, disable the Book Now button
            btnBookPkg1.Enabled = false;
            lblPkg1NotAvailable.Visible = true;

        }
    }
     protected void FormViewPkg2_DataBound(object sender, EventArgs e)
    {
        //call the CheckDates method to see if the dates are valid
        FormView currentForm;
        currentForm = FormViewPkg2;
        //declare a bool to keep track if the dates are valid
        bool validDates = true;
        validDates = CheckDates(currentForm);
        if (validDates == false)
        {
            //if dates are not valid, disable the Book Now button
            btnBookPkg2.Enabled = false;
            lblPkg2NotAvailable.Visible = true;

        }
    }
    protected void FormViewPkg3_DataBound(object sender, EventArgs e)
    {
        //call the CheckDates method to see if the dates are valid
        FormView currentForm;
        currentForm = FormViewPkg3;
        //declare a bool to keep track if the dates are valid
        bool validDates = true;
        validDates = CheckDates(currentForm);
        if (validDates == false)
        {
            //if dates are not valid, disable the Book Now button
            btnBookPkg3.Enabled = false;
            lblPkg3NotAvailable.Visible = true;

        }
    }
    protected void FormViewPkg4_DataBound(object sender, EventArgs e)
    {
        //call the CheckDates method to see if the dates are valid
        FormView currentForm;
        currentForm = FormViewPkg4;
        //declare a bool to keep track if the dates are valid
        bool validDates = true;
        validDates = CheckDates(currentForm);
        if (validDates == false)
        {
            //if dates are not valid, disable the Book Now button
            btnBookPkg4.Enabled = false;
            lblPkg4NotAvailable.Visible = true;

        }
    }

    //method checks if the package dates are viable for given formview
    //if dates are not valid, they are highlighted in red
    private static bool CheckDates(FormView currentForm)
    {
        //declare a bool to keep track if the dates are valid
        //presume dates are valid, set it to true
        bool validDates = true;
        //get the Start Date from the formview
        string date = ((Label)currentForm.FindControl("PkgStartDateLabel")).Text;
        //get today's date and save into today variable
        DateTime startDate = Convert.ToDateTime(date);
        DateTime today = DateTime.Today;
        //comapre dates
        int result = DateTime.Compare(startDate, today);
        if (result < 0) //startDate is earlier than today
        //highlight the date red
        {
            Label lbl = (Label)currentForm.FindControl("PkgStartDateLabel");
            //assign css class that has font set to red
            lbl.CssClass = "changeFont";
            validDates = false;
        }
        date = ((Label)currentForm.FindControl("PkgEndDateLabel")).Text;
        DateTime endDate = Convert.ToDateTime(date);
        result = DateTime.Compare(endDate, today);
        if (result < 0) //endDate is earlier than today
        //highlight the date red
        {
            Label lbl = (Label)currentForm.FindControl("PkgEndDateLabel");
            //assign css class that has font set to red
            lbl.CssClass = "changeFont";
            validDates = false;
        }
        return validDates;
    }

    private void ResetErrorMsgs()
    {
        //reset all messages' visible property to false
        lblPkg1NotAvailable.Visible = false;
        lblPkg2NotAvailable.Visible = false;
        lblPkg3NotAvailable.Visible = false;
        lblPkg4NotAvailable.Visible = false;
    }
}