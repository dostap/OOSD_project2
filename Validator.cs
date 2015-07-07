using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsData
{
    //Provides static methods for validating data.
    //Code liberally borrowed from Validator.cs provided as example in class
    public static class Validator
    {
        /// <summary>
        /// The title that will appear in dialog boxes.
        /// </summary>
        private static string title = "Error Entrying Data"; //declare title for error message boxes

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Checks whether the user entered data into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered data.</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")//check for an empty string
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }

                else if (control.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    if (dateTimePicker.Text == "")
                    {
                        MessageBox.Show(dateTimePicker.Tag + " is a required field.", "Entry Error");
                        dateTimePicker.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Checks whether the user entered valid price into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered a decimal value.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal format.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks whether the user entered an int value into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered an int value.</returns>
        /*  public static bool IsInt32(TextBox textBox)
          {
              try
              {
                  Convert.ToInt32(textBox.Text);
                  return true;
              }
              catch (FormatException)
              {
                  MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                  textBox.Focus();
                  return false;
              }
          }*/

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks whether the user entered a value within a specified range into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <param name="min">The minimum value for the range.</param>
        /// <param name="max">The maximum value for the range.</param>
        /// <returns>True if the user has entered a value within the specified range.</returns>
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min.ToString()
                    + " and " + max.ToString() + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        /// <summary>
        /// Checks whether the date the user has entered into DateTimePicker1 is earlier than 
        /// the date entered into DateTimePicker2
        /// </summary>
        /// <param name="DateTimePicker1">The DateTimePicker control user uses to input first date.</param>
        /// <param name="DateTimePicker1">The DateTimePicker control user uses to input second date.</param>
        /// <returns>True if the user has entered first date as earlier than the second date.</returns>

        public static bool AreDatesValid(Control DateTimePicker1, Control DateTimePicker2)
        {

            if (DateTime.Compare(Convert.ToDateTime(DateTimePicker1.Text), Convert.ToDateTime(DateTimePicker2.Text)) > 0)
            {
                MessageBox.Show("End Date must be later than Start Date.", Title);

                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks whether the date the user has entered a greater value into second textbox.
        /// Uses decimla format for comparison
        /// </summary>
        /// <param name="textBox1">The TextBox control user uses to input first number.</param>
        /// <param name="textBox2">The TextBox control user uses to input second number.</param>
        /// <returns>True if the user has entered a greater value into textbox2.</returns>
        public static bool IsGreater(TextBox textBox1, TextBox textBox2)
        {
            decimal number1 = Convert.ToDecimal(textBox1.Text);
            decimal number2 = Convert.ToDecimal(textBox2.Text);

            if(number1 < number2)
            {
                MessageBox.Show(textBox1.Tag + " has to be greater than " + textBox2.Tag, Title);
                return false;
            }
            else
            {
                return true;
            }
        
        }

    }
}
