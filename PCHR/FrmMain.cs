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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuMedicalDetails_Click(object sender, EventArgs e)
        {
            //creates new Medical Details form
            Form MedicalDetails = new FrmMedicalDetails();
            MedicalDetails.MdiParent = this;
            MedicalDetails.Show();
        }
            //creates new Person Details form
        private void mnuPersonalDetails_Click(object sender, EventArgs e)
        {
            Form PersonalDetails = new FrmPersonalDetails();
            PersonalDetails.MdiParent = this;
            PersonalDetails.Show();
        }

        private void mnuCPHR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, that sign of the application is currently under construction!");
        }

        private void mnuEPHR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, that sign of the application is currently under construction!");
        }
    }
}
