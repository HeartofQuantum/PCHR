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

        /*private void mnuItemPersonalDetails_Click(object sender, EventArgs e)
        {
            FrmPersonalDetails PersonalDetails = new FrmPersonalDetails();
            PersonalDetails.MdiParent = this; 
            PersonalDetails.Show();
        }*/

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
            //
            Form MedicalDetails = new FrmMedicalDetails();
            MedicalDetails.MdiParent = this;
            MedicalDetails.Show();
        }

        private void mnuPersonalDetails_Click(object sender, EventArgs e)
        {
            Form PersonalDetails = new FrmPersonalDetails();
            PersonalDetails.MdiParent = this;
            PersonalDetails.Show();
        }
    }
}
