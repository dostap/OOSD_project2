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
    public partial class frmAddModifyPackage : Form
    {
        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        public bool addPackage;
        public Package package;



        private void ClearControls()//resets the form
        {
            pkgNameTextBox.Text = "";
            pkgDescTextBox.Text = "";
            pkgStartDateDateTimePicker.Text = "";
            pkgEndDateDateTimePicker.Text = "";
            pkgBasePriceTextBox.Text = "";
            pkgAgencyCommissionTextBox.Text = "";
            btnClear.Enabled = false;
            
        }

        private void DisplayPackage()
        {
            pkgNameTextBox.Text = package.PkgName;
            pkgStartDateDateTimePicker.Text = package.PkgStartDate.ToString("d MMM yyyy");
            pkgEndDateDateTimePicker.Text = package.PkgEndDate.ToString("d MMM yyyy");
            pkgBasePriceTextBox.Text = package.PkgBasePrice.ToString("F2");
            pkgDescTextBox.Text = package.PkgDesc;
            pkgAgencyCommissionTextBox.Text = package.PkgAgencyCommission.ToString("F2");
        }

        private void PutPackageData(Package package)//basically the opposite of DiplayPackage
        //this grabs data from the textboxes and assigns it to variables
        {
            //  package.PackageId = Convert.ToInt32(txtPkgId.Text);
            package.PkgName = pkgNameTextBox.Text;
            package.PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text);
            package.PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text);
            package.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
            package.PkgDesc = pkgDescTextBox.Text;
            package.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);

        }
    
        private bool IsDataValid()
        {
            return
                //  Validator.IsPresent(txtPkgId) &&
                Validator.IsPresent(pkgNameTextBox) &&

                Validator.IsPresent(pkgStartDateDateTimePicker) &&
                Validator.IsPresent(pkgEndDateDateTimePicker) &&
                Validator.AreDatesValid(pkgStartDateDateTimePicker,
                                        pkgEndDateDateTimePicker) &&

                Validator.IsPresent(pkgBasePriceTextBox) &&
                Validator.IsDecimal(pkgBasePriceTextBox) &&

                Validator.IsPresent(pkgDescTextBox) &&

                Validator.IsPresent(pkgAgencyCommissionTextBox) &&
                Validator.IsDecimal(pkgAgencyCommissionTextBox) &&

                Validator.IsGreater(pkgBasePriceTextBox, pkgAgencyCommissionTextBox);
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsDataValid()) 
            {
                //&& Validator.AreDatesValid(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker))

                if (addPackage) // check Boolean flag for adding a package
                {
                    
                    package = new Package(); //new instance of class Package
                    this.PutPackageData(package); //call PutPackageData method to populate package with user's inputs
                    try
                    {
                        package.PackageId = PackageDB.AddPackage(package);
                        MessageBox.Show("Package '" + package.PkgName + "' added!");//send user a message that the package has been added
                        //for peace of mind....
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                
                } // end of adding product section

                else //if we are not adding, we must be modifying
                {
                    Package newPackage = new Package(); //if we are modifying
                    //create new instance of Package
                    newPackage.PackageId = package.PackageId; //let newPackage get the properties of the package we are modiyfing
                    this.PutPackageData(newPackage); 
                    try
                    {
                        if (!PackageDB.EditPackage(package, newPackage))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that package.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            package = newPackage;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }

                }//of of modifying package code

            } //closing if bracket

            }//end of button click method
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddModifyPackage_Load_2(object sender, EventArgs e)
        {
            //this.LoadStateComboBox();
            if (addPackage) //if vaue is set to true - we are adding
            {
                this.Text = "Add Package";
            }
            else //if not adding, we must be modifying. limited options here.
            {
                this.Text = "Modify Package Information";
                this.DisplayPackage(); //populate form fields with product information
            }
        }
    }
}
