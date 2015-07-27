/* 
 * This is the LogIn form
 * Currently it is a dummy form but later it will validate the users
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit the entire application
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // hide this form and show the main menu
            frmMainMenu mainmenu = new frmMainMenu();
            this.Hide();
            mainmenu.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when the user press enter, call the search button method
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnLogIn_Click(sender, e);
            }
        }


    }
}
