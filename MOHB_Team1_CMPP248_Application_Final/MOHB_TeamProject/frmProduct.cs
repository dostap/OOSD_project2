/* 
 * This is the Product form which displays its data besides its suppliers
 * It gives the choice to add, modify or delete of a product
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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private Product product;

        private void frmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnMainMenu_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtProductId))
            {
                try
                {
                    // call the GetProduct method which will search for the product by its id and retrieve it to product variable
                    product = ProductDB.GetProductId(Convert.ToInt32(txtProductId.Text));
                    if (product == null)
                    {
                        MessageBox.Show("No product found with this code, please try again.", "Product Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        // if a product found, displays the data and fill the grid with the suppliers of that product
                        this.DisplayProduct();
                        List<Supplier> suppliers = ProductDB.GetSuppliersOfProduct(Convert.ToInt32(txtProductId.Text));
                        dgvSuppliers.DataSource = suppliers;
                        DataGridViewColumn column = dgvSuppliers.Columns[0];
                        column.Width = 80; // adjust the ID column width
                        column = dgvSuppliers.Columns[1];
                        column.Width = 350; // adjust the Name column width
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
            txtProductId.Text = "";
            txtProductName.Text = "";
            dgvSuppliers.DataSource = null;
            btnModify.Enabled = false; // disable the modify button since there is no product displayed
            btnDelete.Enabled = false; // disable the delete button since there is no product displayed
            txtProductId.Focus();
        }

        private void DisplayProduct()
        {
            // display the data from the object into the text boxes
            txtProductId.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProdName;
            btnModify.Enabled = true; // enable the modify button after displaying the product so the user can use it
            btnDelete.Enabled = true; // enable the delete button after displaying the product so the user can use it
        }

        private void frmProducts_Activated(object sender, EventArgs e)
        {
            txtProductId.Focus();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // return back to the main menu
            frmMainMenu mainmenu = new frmMainMenu();
            this.Hide();
            mainmenu.Show();
        }

        private void txtProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when the user press enter, call the search button method
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // open the add/modify form in the add mode
            frmProductDataChange addProductForm = new frmProductDataChange();
            addProductForm.addMode = true;
            DialogResult result = addProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the newly added product from the add/modify form to this form and display the product data
                dgvSuppliers.DataSource = null;
                product = addProductForm.product;
                this.DisplayProduct();
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // open the add/modify form in the modify mode
            frmProductDataChange modifyProductForm = new frmProductDataChange();
            modifyProductForm.addMode = false;
            modifyProductForm.product = product;
            DialogResult result = modifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the modified product from the add/modify form to this form and display the product data after modification
                product = modifyProductForm.product;
                this.DisplayProduct();
            }
            else if (result == DialogResult.Retry)
            {
                btnSearch_Click(sender, e);
                if (product != null) this.DisplayProduct();
                else this.ClearControls();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // display a confirmation message before deleting
            DialogResult result = MessageBox.Show("Delete " + product.ProdName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                // call the delete method and clear the textboxes if succeeded.
                if (ProductDB.DeleteProduct(product))
                {
                    this.ClearControls();
                }
                else
                {
                    MessageBox.Show("Another user has updated or deleted that product.", "Database Error");
                    btnSearch_Click(sender, e);
                    if (product != null) this.DisplayProduct();
                    else this.ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

    }
}
