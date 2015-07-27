/* Provides static methods for validating data.
 * Author: Hazem Hegazy
 * Date: Jul-2-15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHB_TeamProject
{
    public static class Validator
    {

        // The title that will appear in dialog boxes.
        private static string title = "Entry Error";

        // Checks whether the user entered data into a text box.
        public static bool IsNotEmpty(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // Checks whether the user entered a double value into a text box.
        public static bool IsDouble(TextBox textBox)
        {
            try
            {
                Convert.ToDouble(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a double number.", title);
                textBox.Focus();
                return false;
            }
        }

        // Checks date format and range.
        public static bool IsDateRange(DateTimePicker dStart, DateTimePicker dEnd)
        {
            DateTime start= Convert.ToDateTime(dStart.Text) ;
            DateTime end = Convert.ToDateTime(dEnd.Text);
            DateTime today = DateTime.Today;

            if (start<today)
            {
                MessageBox.Show(" The start date can not be before today.", title);
                dStart.Focus();
                return false;
            }

            if (end < today)
            {
                MessageBox.Show(" The end date can not be before today.", title);
                dStart.Focus();
                return false;
            }

            if (start > end)
            {
                MessageBox.Show(" The start date can not be after the end date.", title);
                dStart.Focus();
                return false;
            }
            return true;

        }

        // Checks whether the user entered an int value into a text box.
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", title);
                textBox.Focus();
                return false;
            }
        }

        // Checks whether the user entered a positive value into a text box.
        public static bool IsPositive(TextBox textBox)
        {
            if (Convert.ToDouble(textBox.Text) < 0)
            {
                MessageBox.Show(textBox.Tag + " must be positive.", title);
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        // Checks whether the user entered a value within a specified range into a text box.
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min.ToString() + " and " + max.ToString() + ".", title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsGreater(TextBox big, TextBox small)
        {
            double number1 = Convert.ToDouble(big.Text);
            double number2 = Convert.ToDouble(small.Text);

            if (number1 < number2)
            {
                MessageBox.Show(big.Tag + " has to be greater than " + small.Tag, title);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
