/* 
 * This is the Supplier change form which accept the users data for the new (or modified) supplier
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
    public partial class frmSupplierDataChange : Form
    {
        public bool addMode; // create a flag to decide whether this for in the add or modify mode
        public Supplier supplier;

        public frmSupplierDataChange()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
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

        private void DisplaySupplier()
        {
            txtSupplierName.Text = supplier.SupName;
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
                supplier = new Supplier();
                this.AcceptSupplierData(supplier);
                try
                {
                    // call add supplier method to save the entered data and return the id of the new package
                    supplier.SupplierId = SupplierDB.AddSupplier(supplier);
                    if (supplier.SupplierId > 0)
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
                Supplier newSupplier = new Supplier();
                newSupplier.SupplierId = supplier.SupplierId;
                this.AcceptSupplierData(newSupplier);
                try
                {
                    // call the edit package methode and check if succeeded
                    if (SupplierDB.UpdateSupplier(supplier, newSupplier))
                    {
                        supplier = newSupplier;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Another user has already updated or deleted that supplier.", "Database Error");
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
            return Validator.IsNotEmpty(txtSupplierName);
        }

        private void AcceptSupplierData(Supplier supplier)
        {
            supplier.SupName = txtSupplierName.Text;
        }

        private void frmSupplierDataChange_Activated(object sender, EventArgs e)
        {
            txtSupplierName.Focus();
        }

        private void frmSupplierDataChange_Load(object sender, EventArgs e)
        {
            // change the form title according to the mode
            if (addMode)
            {
                this.Text = "Add New Supplier";
            }
            else
            {
                this.Text = "Modify Supplier";
                this.DisplaySupplier();
            }
        }

    }
}
