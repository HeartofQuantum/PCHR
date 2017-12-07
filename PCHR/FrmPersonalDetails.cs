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
    public partial class FrmPersonalDetails : Form
    {
        public FrmPersonalDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpLoginDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuMedicalDetails_Click(object sender, EventArgs e)
        {
            
            Form newForm = new FrmMedicalDetails();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void mnuPersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void mnuEPHC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently under construction and will be coming soon!");
        }

        private void mnuCPHC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently under construction and will be coming soon!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblKinAddress_Click(object sender, EventArgs e)
        {

        }

        private void linkLoginCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkProviderSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FrmPersonalDetails_Load(object sender, EventArgs e)
        {

        }

        private void linkLoginEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
