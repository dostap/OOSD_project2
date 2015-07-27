/* 
 * This is the Package change form which accept the users data for the new (or modified) package
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
    public partial class frmPackageDataChange : Form
    {
        public bool addMode; // create a flag to decide whether this for in the add or modify mode
        public Package package; // create a package object

        public frmPackageDataChange()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (txtPkgName.Text == "")
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

        private void DisplayPackage()
        {
            // display the data from the package object
            txtPkgName.Text = package.PkgName;
            dtpPkgStartDate.Text = package.PkgStartDate.ToString("dd-MMM-yyyy");
            dtpPkgEndDate.Text = package.PkgEndDate.ToString("dd-MMM-yyyy");
            txtPkgDesc.Text = package.PkgDesc.ToString();
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgAgencyCommission.Text = package.PkgAgencyCommission.ToString();
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
                package = new Package();
                this.AcceptPackageData(package);
                try
                {
                    // call add package method to save the entered data and return the id of the new package
                    package.PackageId = PackageDB.AddPackage(package);
                    if (package.PackageId > 0)
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
                Package newPackage = new Package();
                newPackage.PackageId = package.PackageId;
                this.AcceptPackageData(newPackage);
                try
                {
                    // call the edit package methode and check if succeeded
                    if (PackageDB.EditPackage(package, newPackage))
                    {
                        package = newPackage;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Another user has already updated or deleted that package.", "Database Error");
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
            return
                Validator.IsNotEmpty(txtPkgName) &&
                Validator.IsDateRange(dtpPkgStartDate, dtpPkgEndDate) &&
                Validator.IsNotEmpty(txtPkgDesc) &&
                Validator.IsNotEmpty(txtPkgBasePrice) &&
                Validator.IsNotEmpty(txtPkgAgencyCommission) &&
                Validator.IsDouble(txtPkgBasePrice) &&
                Validator.IsDouble(txtPkgAgencyCommission) &&
                Validator.IsPositive(txtPkgBasePrice) &&
                Validator.IsPositive(txtPkgAgencyCommission) &&
                Validator.IsGreater(txtPkgBasePrice, txtPkgAgencyCommission);
        }

        private void AcceptPackageData(Package package)
        {
            // accept data feom the controls into the object
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = Convert.ToDateTime(dtpPkgStartDate.Text);
            package.PkgEndDate = Convert.ToDateTime(dtpPkgEndDate.Text);
            package.PkgDesc = txtPkgDesc.Text;
            package.PkgBasePrice =Convert.ToDouble(txtPkgBasePrice.Text);
            package.PkgAgencyCommission = Convert.ToDouble(txtPkgAgencyCommission.Text);
        }

        private void frmPackageDataChange_Activated(object sender, EventArgs e)
        {
            txtPkgName.Focus();
        }

        private void frmPackageDataChange_Load(object sender, EventArgs e)
        {
            // change the form title according to the mode
            if (addMode)
            {
                this.Text = "Add New Package";
            }
            else
            {
                this.Text = "Modify Package";
                this.DisplayPackage();
            }
        }
    }
}
