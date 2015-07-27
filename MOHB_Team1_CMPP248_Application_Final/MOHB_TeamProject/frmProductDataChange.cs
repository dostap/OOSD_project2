/* 
 * This is the Product change form which accept the users data for the new (or modified) product
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
    public partial class frmProductDataChange : Form
    {
        public bool addMode; // create a flag to decide whether this for in the add or modify mode
        public Product product;

        public frmProductDataChange()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                this.Close();
            }
            else
            {
                // ask for confirmation before canceling
                DialogResult result = MessageBox.Show("This will disregard any unsaved data, continue ?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) this.Close();
            }
            this.Hide();
        }

        private void frmProductDataChange_Load(object sender, EventArgs e)
        {
            // change the form title according to the mode
            if (addMode)
            {
                this.Text = "Add New Product";
            }
            else
            {
                this.Text = "Modify Product";
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtProductName.Text = product.ProdName;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!IsValidData()) return;

            // ask for confirmation before saving
            DialogResult result = MessageBox.Show("Save the entered data?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            if (addMode) // add mode
            {
                // call method to accept the data from the message boxes
                product = new Product();
                this.AcceptProductData(product);
                try
                {
                    // call add product method to save the entered data and return the id of the new package
                    product.ProductId = ProductDB.AddProduct(product);
                    if (product.ProductId > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else // modify mode
            {
                Product newProduct = new Product();
                newProduct.ProductId = product.ProductId;
                this.AcceptProductData(newProduct);
                try
                {
                    // call the edit product methode and check if succeeded
                    if (ProductDB.EditProduct(product, newProduct))
                    {
                        product = newProduct;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Another user has already updated or deleted that product.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // validate that all the textboxes are full, unitprice is double and onhandquantity is integer
        private bool IsValidData()
        {
            return Validator.IsNotEmpty(txtProductName);
        }

        private void AcceptProductData(Product product)
        {
            product.ProdName = txtProductName.Text;
        }

        private void frmProductDataChange_Activated(object sender, EventArgs e)
        {
            txtProductName.Focus();
        }
    }
}
