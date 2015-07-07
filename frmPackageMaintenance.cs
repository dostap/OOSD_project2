using TravelExpertsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSDWorkProj2
{
    public partial class frmPackageMaintenance : Form
    {
        public frmPackageMaintenance()
        {
            InitializeComponent();
        }

        private Package package; //create an instance of Package class

        private void btnGetPackage_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(packageIdTextBox) && Validator.IsInt32(packageIdTextBox))
            {
                int packageId = Convert.ToInt32(packageIdTextBox.Text);
                package = PackageDB.GetPackage(packageId); //calls GetPackage method of PackageDB class
                if (package == null)
                {
                    MessageBox.Show("No package found with this code. " +
                         "Please try again.", "Product Not Found");
                    this.ClearControls(); //reset form fields to empty 
                }
                else
                {
                    this.DisplayPackage();//populate fields with data
                    btnModify.Enabled = true;
                    btnClear.Enabled = true;
                    btnDelete.Enabled = true;

                    List<string> listOfProdSup = new List<string>();
                    listOfProdSup = PackageDB.GetProductsAndSuppliers(packageId);
                    foreach (string s in listOfProdSup)
                    {
                        MessageBox.Show("Products and Suppliers: " + s);
                    }
                }

              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage addPackageForm = new frmAddModifyPackage();  //instantiate new Add form
            addPackageForm.addPackage = true; //set bool to true that we are adding a product
            //this is used to differentiate adding and modifying (form heading)

            DialogResult result = addPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = addPackageForm.package; //grab the object from the Add/Modify Product form
                
                this.DisplayPackage(); // populate textboxes with data from the newly created product
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage modifyPackageForm = new frmAddModifyPackage();
            modifyPackageForm.addPackage = false;
            //this is used to differentaite betwwn adding and modifying
            modifyPackageForm.package = package;
            DialogResult result = modifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = modifyPackageForm.package;
                this.DisplayPackage();
            }
            else if (result == DialogResult.Retry)
            {
                int packageId = Convert.ToInt32(packageIdTextBox.Text);
                package = PackageDB.GetPackage(packageId); 
                //calls GetPackage method of PackageDB class
                if (package != null)
                    this.DisplayPackage();
                else
                    this.ClearControls();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + package.PackageId + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!PackageDB.DeletePackage(package))
                    {
                        int packageId = Convert.ToInt32(packageIdTextBox.Text);
                        MessageBox.Show("Another user has updated or deleted " +
                            "that product.", "Database Error");
                        package = PackageDB.GetPackage(packageId); //calls GetPackage method of PackageDB class
                        // this.GetPackage(package.PackageId);
                        if (package != null)
                            this.DisplayPackage();
                        MessageBox.Show("Package '" + package.PkgName + "' deleted!");
                        //send user a message that the package has been deleted
                        //for peace of mind....
                    }
                    else
                        this.ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void ClearControls()//resets the form
        {
            pkgNameTextBox.Text = "";
            packageIdTextBox.Text = "";
            pkgDescTextBox.Text = "";
            pkgStartDateDateTimePicker.Text = "";
            pkgEndDateDateTimePicker.Text = "";
            pkgBasePriceTextBox.Text = "";
            pkgAgencyCommissionTextBox.Text = "";
            btnModify.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DisplayPackage()
        {
            packageIdTextBox.Text = package.PackageId.ToString();
            pkgNameTextBox.Text = package.PkgName;
            pkgStartDateDateTimePicker.Text = package.PkgStartDate.ToString("d MMM yyyy");
            pkgEndDateDateTimePicker.Text = package.PkgEndDate.ToString("d MMM yyyy");
            pkgBasePriceTextBox.Text = package.PkgBasePrice.ToString("c");
            pkgDescTextBox.Text = package.PkgDesc;
            pkgAgencyCommissionTextBox.Text = package.PkgAgencyCommission.ToString("c");
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            this.ClearControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
