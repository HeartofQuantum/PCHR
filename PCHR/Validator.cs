using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHR
{
    public static class Validator
    {
        private static string title = "Entry error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        //tests to see if there is input in the textbox and combo boxes
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field. ", Title);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag + "is a required field. ", Title);
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

    }
}
