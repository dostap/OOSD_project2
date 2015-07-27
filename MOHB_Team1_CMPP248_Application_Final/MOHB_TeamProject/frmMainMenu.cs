/* 
 * This is the Main Menu form which gives access to the solution forms
 * Author: Hazem Hegazy
 * Date: Jul-2015
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHB_TeamProject
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // get back to the login form in case the user close this form
            frmLogIn login = new frmLogIn();
            this.Hide();
            login.Show();
        }

        private void btnProductsForm_Click(object sender, EventArgs e)
        {
            // hide this form and displays the product form
            frmProduct product = new frmProduct();
            this.Hide();
            product.Show();
        }

        private void btnSuppliersForm_Click(object sender, EventArgs e)
        {
            // hide this form and displays the supplier form
            frmSupplier supplier = new frmSupplier();
            this.Hide();
            supplier.Show();
        }

        private void btnPackagesForm_Click(object sender, EventArgs e)
        {
            // hide this form and displays the product form
            frmPackage package = new frmPackage();
            this.Hide();
            package.Show();
        }

    }
}
