using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHR
{
    public partial class fmLogin : Form
    {
        public fmLogin()
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

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmRegistration());
            frmRegistration registration = new frmRegistration();
            registration.Show();

        }
    }
}
