using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCHR
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void fmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                try
                {
                    //validates whether or not the user and password match the database entries
                    Patient you = PatientDB.Login(txtUsername.Text, txtPassword.Text);
                    if (you.USERNAME == txtUsername.Text && you.PWORD == txtPassword.Text)
                    {
                        Form main = new FrmMain();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, something went wrong with your login. ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    MessageBox.Show("Your password or username does not match a user within the database. Please register.");
                }
            }
            else
            {
                MessageBox.Show("You must filled out the user and password fields. ");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtPassword);
        }

    }
}
