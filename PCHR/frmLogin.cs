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
         //   string password = txtPassword.Text;
         //   string username = txtPassword.Text;

            FrmMain HealthRecord = new FrmMain();            
            //HealthRecord.MdiParent = this;
            HealthRecord.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmRegistration());
            FrmRegister register = new FrmRegister();
            register.Show();

        }
    }
}
