/* 
 * This is the Package form which displays its data besides its suppliers-products
 * It gives the choice to add, modify or delete of a package
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
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        // create the package object
        private Package package;

        private void frmPackages_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnMainMenu_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtPackageId))
            {
                try
                {
                    // call the GetPackage method which will search for the package by its id and retrieve it to package variable
                    package = PackageDB.GetPackage(Convert.ToInt32(txtPackageId.Text));
                    if (package == null)
                    {
                        MessageBox.Show("No package found with this code, please try again.", "Package Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        // if a package found, displays the data and fill the grid with the suppliers-product of that package
                        this.DisplayPackage();
                        FillProductList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }

        }

        private void ClearControls()
        {
            // clear all the controls and return focus to the first text box
            txtPackageId.Text = "";
            txtPkgName.Text = "";
            lstSuppliersProducts.DataSource = null;
            txtPkgStartDate.Text = "";
            txtPkgEndDate.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgencyCommission.Text = "";
            cbxSuppliers.Visible = false;
            cbxProducts.Visible = false;
            btnAcceptProduct.Visible = false;
            btnModify.Enabled = false; // disable the modify button since there is no package displayed
            btnDelete.Enabled = false; // disable the delete button since there is no package displayed
            txtPackageId.Focus();
        }

        private void DisplayPackage()
        {
            // display the data from the package object
            txtPackageId.Text = package.PackageId.ToString();
            txtPkgName.Text = package.PkgName;
            txtPkgStartDate.Text = package.PkgStartDate.ToString("dd-MMM-yyyy");
            txtPkgEndDate.Text = package.PkgEndDate.ToString("dd-MMM-yyyy");
            txtPkgDesc.Text = package.PkgDesc.ToString();
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString("c");
            txtPkgAgencyCommission.Text = package.PkgAgencyCommission.ToString("c");
            btnModify.Enabled = true; // enable the modify button after displaying the package so the user can use it
            btnDelete.Enabled = true; // enable the delete button after displaying the package so the user can use it
        }

        private void frmPackages_Activated(object sender, EventArgs e)
        {
            txtPackageId.Focus();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // return back to the main menu
            frmMainMenu mainmenu = new frmMainMenu();
            this.Hide();
            mainmenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // open the add/modify form in the add mode
            frmPackageDataChange addPackageForm = new frmPackageDataChange();
            addPackageForm.addMode = true;
            DialogResult result = addPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the newly added package from the add/modify form to this form and display the package data
                lstSuppliersProducts.DataSource = null;
                package = addPackageForm.package;
                this.DisplayPackage();
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // open the add/modify form in the modify mode
            frmPackageDataChange modifyPackageForm = new frmPackageDataChange();
            modifyPackageForm.addMode = false;
            modifyPackageForm.package = package;
            DialogResult result = modifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the modified package from the add/modify form to this form and display the package data after modification
                package = modifyPackageForm.package;
                this.DisplayPackage();
            }
            else if (result == DialogResult.Retry)
            {
                btnSearch_Click(sender, e);
                if (package != null) this.DisplayPackage();
                else this.ClearControls();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // display a confirmation message before deleting
            DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                // call the delete method and clear the textboxes if succeeded.
                if (PackageDB.DeletePackage(package))
                {
                    this.ClearControls();
                }
                else
                {
                    MessageBox.Show("Another user has updated or deleted that package.", "Database Error");
                    btnSearch_Click(sender, e);
                    if (package != null) this.DisplayPackage();
                    else this.ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void txtPackageId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when the user press enter, call the search button method
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtPackageId))
            {
                // display suppliers and product comboboxes and the accept product
                cbxProducts.Visible = true;
                cbxSuppliers.Visible = true;
                btnAcceptProduct.Visible = true;

                // fill the product combo box with the products list retrieved from GetAllProducts method
                List<Product> products = new List<Product>();
                products = ProductDB.GetAllProducts();
                cbxProducts.DataSource = products;
                cbxProducts.DisplayMember = "ProdName";
                cbxProducts.ValueMember = "ProductID";
                cbxProducts_SelectionChangeCommitted(sender, e); // execute this event to fill the suppliers combo box for the first time
            }
        }

        private void cbxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxProducts.SelectedIndex >= 0)
            {
                try
                {   // retrieve all the suppliers of the chosen product
                    List<Supplier> suppliers = ProductDB.GetSuppliersOfProduct(Convert.ToInt32(cbxProducts.SelectedValue));
                    cbxSuppliers.DataSource = null;
                    cbxSuppliers.DataSource = suppliers;
                    cbxSuppliers.DisplayMember = "SupName";
                    cbxSuppliers.ValueMember = "SupplierID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // calling method to add the selected product to the chosen package
                if (PackageDB.AddProductToPackage(Convert.ToInt32(txtPackageId.Text) , (int)cbxProducts.SelectedValue, (int)cbxSuppliers.SelectedValue))
                {
                    FillProductList(); // refresh the product grid so as to add the new added product to the list of the chosen supplier
                }
                else // in case addition failed
                {
                    MessageBox.Show("Saving failed, please try again.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void FillProductList()
        {
            List<string> suppliers_products = PackageDB.GetProductsAndSuppliers(Convert.ToInt32(txtPackageId.Text));
            lstSuppliersProducts.DataSource = suppliers_products;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // display a confirmation message before removing the product from the package
            DialogResult result = MessageBox.Show("Remove " + lstSuppliersProducts.SelectedItem.ToString() + " from the package?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            if (lstSuppliersProducts.SelectedIndex >= 0)
            {
                //extract the ProductSupplierId from the selected item of the list
                int prodSupId;
                string[] psId = new string[2];
                psId = lstSuppliersProducts.SelectedItem.ToString().Split(')');
                prodSupId = Convert.ToInt32(psId[0]);

                try
                {
                    // calling method to remove the selected product from the chosen package
                    if (PackageDB.RemoveProductFromPackage(Convert.ToInt32(txtPackageId.Text), prodSupId))
                    {
                        FillProductList(); // refresh the product grid so as to remove the selected product from the list
                    }
                    else // in case delete failed
                    {
                        MessageBox.Show("Deleting failed, please try again.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

    }
}
