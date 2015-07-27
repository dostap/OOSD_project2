// OOSD Workshop 2 - Travel Experts
// July 2, 2015
//Written by Darya Ostapenko
//Purpose: creation of BookPackageDB class with methods connecting to the database and alidating user inputs

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerPackages : System.Web.UI.Page
{
    int customerId;
    decimal totalAmountDueForProducts = 0;
    decimal totalAmountDueForPackages = 0;

   protected void Page_Load(object sender, EventArgs e)
    {
        lblPasswordChanged.Visible = false;
        
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

        // if there is no customer deny access to page redirect to missing404
        if (Session["customerId"] == null)
        {

            Response.Redirect("~/Missing404.aspx");
        }
        else
        {
            //get the session variable
            customerId = Convert.ToInt32(Session["customerId"]);
            //calculate total amounts
            totalAmountDueForProducts = InvoiceDB.GetTotalAmountDueForProducts(customerId);
            totalAmountDueForPackages = BookPackageDB.GetTotalAmountDueForPackages(customerId);
            //show total amounts in labels
            lblTotalAmountForPackages.Text = "Total Amount Due for Packages: " + totalAmountDueForPackages.ToString("c");
            lblTotalAmountForProducts.Text = "Total Amount Due for Products: " + totalAmountDueForProducts.ToString("c");

        }

        
    }

//DetailsVIew1 is the details view at the top of hte page
    //displaying Cuastomer's name and total amounts due
   protected void DetailsView1_DataBound(object sender, EventArgs e)
   {
       // Get the footer row.
       DetailsViewRow footerRow = DetailsView1.FooterRow;

       // Get the Label control 
       Label totalAmount =
           (Label)footerRow.Cells[0].FindControl("lblFinalAmount");

           // Update the Label control with the total amounts due        
           totalAmount.Text = "Total Amount Due Products: " + totalAmountDueForProducts.ToString("c")
               + "</br>"
               + "Total Amount Due for Packages: " + totalAmountDueForPackages.ToString("c")
               + "</br>"
               + "Overall Total: " + (totalAmountDueForPackages + totalAmountDueForProducts).ToString("c");
   }

   // on press of the save button in change password
   protected void UpdateButton_Click(object sender, EventArgs e)
   {
       TextBox newPassword = (TextBox)fvChangePassword.FindControl("CustPasswordTextBox");
       TextBox confirmPassword = (TextBox)fvChangePassword.FindControl("ConfirmPasswordTextBox");
       // if page is valid hashed the password fields
       if (Page.IsValid)
           newPassword.Text = CustomerDB.GenerateCustPassword(newPassword.Text);
       confirmPassword.Text = CustomerDB.GenerateCustPassword(confirmPassword.Text);
       lblPasswordChanged.Visible = true; // display a confirmation message
   }
}