/* 
 * This is the Supplier form which displays its data besides its products
 * It gives the choice to add, modify or delete of a supplier
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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        // create a supplier object
        private Supplier supplier;

        private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnMainMenu_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtSupplierId))
            {
                try
                {
                    // call the GetSupplier method which will search for the supplier by its id and retrieve it to supplier variable
                    supplier = SupplierDB.GetSupplier(Convert.ToInt32(txtSupplierId.Text));
                    if (supplier == null)
                    {
                        MessageBox.Show("No supplier found with this code, please try again.", "Supplier Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        // if a supplier found, displays the data and fill the products and contacts grid with the products of that supplier
                        this.DisplaySupplier();
                        FillProductGrid();
                        FillContactGrid();
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
            txtSupplierId.Text = "";
            txtSupplierName.Text = "";
            dgvProducts.DataSource = null;
            dgvContacts.DataSource = null;
            btnModify.Enabled = false; // disable the modify button since there is no supplier displayed
            btnDelete.Enabled = false; // disable the delete button since there is no supplier displayed
            cbxProducts.Visible = false;
            btnAcceptProduct.Visible = false;
            txtSupplierId.Focus();
        }

        private void DisplaySupplier()
        {
            txtSupplierId.Text = supplier.SupplierId.ToString();
            txtSupplierName.Text = supplier.SupName;
            btnModify.Enabled = true; // enable the modify button after displaying the product so the user can use it
            btnDelete.Enabled = true; // enable the delete button after displaying the product so the user can use it
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
            frmSupplierDataChange addSupplierForm = new frmSupplierDataChange();
            addSupplierForm.addMode = true;
            DialogResult result = addSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the newly added product from the add/modify form to this form and display the product data
                dgvProducts.DataSource = null;
                dgvContacts.DataSource = null;
                supplier = addSupplierForm.supplier;
                this.DisplaySupplier();
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // open the add/modify form in the modify mode
            frmSupplierDataChange modifySupplierForm = new frmSupplierDataChange();
            modifySupplierForm.addMode = false;
            modifySupplierForm.supplier = supplier;
            DialogResult result = modifySupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // copy the modified supplier from the add/modify form to this form and display the supplier data after modification
                supplier = modifySupplierForm.supplier;
                this.DisplaySupplier();
            }
            else if (result == DialogResult.Retry)
            {
                btnSearch_Click(sender, e);
                if (supplier != null) this.DisplaySupplier();
                else this.ClearControls();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + supplier.SupName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                // call the delete method and clear the textboxes if succeeded.
                if (SupplierDB.DeleteSupplier(supplier))
                {
                    this.ClearControls();
                }
                else
                {
                    MessageBox.Show("Another user has updated or deleted that product.", "Database Error");
                    btnSearch_Click(sender, e);
                    if (supplier != null) this.DisplaySupplier();
                    else this.ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void frmSupplier_Activated(object sender, EventArgs e)
        {
            txtSupplierId.Focus();
        }

        private void txtSupplierId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // when the user press enter, call the search button method
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtSupplierId))
            {
                // display the product combobox and the accept product button
                cbxProducts.Visible = true;
                btnAcceptProduct.Visible = true;

                // fill the product combo box with the products list retrieved from GetAllProducts method
                List<Product> products = new List<Product>();
                products = ProductDB.GetAllProducts();
                cbxProducts.DataSource = products;
                cbxProducts.DisplayMember = "ProdName";
                cbxProducts.ValueMember = "ProductID";
            }
        }

        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // calling method to add the selected product to the chosen supplier
                if (SupplierDB.AddProductToSupplier(Convert.ToInt32(txtSupplierId.Text), (int)cbxProducts.SelectedValue))
                {
                    FillProductGrid(); // refresh the product grid so as to add the new added product to the list of the chosen supplier
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

        private void FillProductGrid()
        {
            // fill the products grid with the list retrieved from the database of the chosen supplier
            List<Product> products = SupplierDB.GetProductsOfSupplier(Convert.ToInt32(txtSupplierId.Text));
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
            DataGridViewColumn column = dgvProducts.Columns[0];
            column.Width = 100; // adjust the ID column width
            column = dgvProducts.Columns[1];
            column.Width = 400; // adjust the Name column width

        }

        private void FillContactGrid()
        {
            // fill the contacts grid with the list retrieved from the database of the chosen supplier
            List<SupplierContact> supplierContacts = SupplierContactDB.GetContactofSupplier(Convert.ToInt32(txtSupplierId.Text));
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = supplierContacts;
            DataGridViewColumn column2 = dgvContacts.Columns[0];
            column2.Width = 0; // adjust the ID column width
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int prodId = (int)dgvProducts.CurrentRow.Cells[0].Value;

            // display a confirmation message before removing the product from the supplier
            DialogResult result = MessageBox.Show("Remove " + dgvProducts.CurrentRow.Cells[1].Value.ToString() + " from the supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            if ((int)dgvProducts.CurrentRow.Cells[0].Value >= 0)
            {
                try
                {
                    // calling method to remove the selected product from the chosen supplier
                    if (SupplierDB.RemoveProductFromSupplier(Convert.ToInt32(txtSupplierId.Text), prodId))
                    {
                        FillProductGrid(); // refresh the product grid so as to remove the selected product from the grid
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

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtSupplierName))
            {
                try
                {
                    // call the GetSupplier method which will search for the supplier by part of its name and retrieve it to supplier variable
                    supplier = SupplierDB.GetSupplierByName(txtSupplierName.Text);
                    if (supplier == null)
                    {
                        MessageBox.Show("No supplier found with this name part, please try again.", "Supplier Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        // if a supplier found, displays the data and fill the products and contacts grid with the products of that supplier
                        this.DisplaySupplier();
                        FillProductGrid();
                        FillContactGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when the user press enter, call the search button method
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnSearchByName_Click(sender, e);
            }
        }

    }
}
