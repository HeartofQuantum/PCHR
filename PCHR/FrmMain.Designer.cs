namespace PCHR
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuPersonalDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicalDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCPHR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEPHR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPersonalDetails,
            this.mnuMedicalDetails,
            this.mnuCPHR,
            this.mnuEPHR,
            this.mnuLogout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(751, 24);
            this.mnuMain.TabIndex = 8;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuPersonalDetails
            // 
            this.mnuPersonalDetails.Name = "mnuPersonalDetails";
            this.mnuPersonalDetails.Size = new System.Drawing.Size(102, 20);
            this.mnuPersonalDetails.Text = "Personal Details";
            this.mnuPersonalDetails.Click += new System.EventHandler(this.mnuPersonalDetails_Click);
            // 
            // mnuMedicalDetails
            // 
            this.mnuMedicalDetails.Name = "mnuMedicalDetails";
            this.mnuMedicalDetails.Size = new System.Drawing.Size(99, 20);
            this.mnuMedicalDetails.Text = "Medical Details";
            this.mnuMedicalDetails.Click += new System.EventHandler(this.mnuMedicalDetails_Click);
            // 
            // mnuCPHR
            // 
            this.mnuCPHR.Name = "mnuCPHR";
            this.mnuCPHR.Size = new System.Drawing.Size(228, 20);
            this.mnuCPHR.Text = "Comprehensive Personal Health Record";
            this.mnuCPHR.Click += new System.EventHandler(this.mnuCPHR_Click);
            // 
            // mnuEPHR
            // 
            this.mnuEPHR.Name = "mnuEPHR";
            this.mnuEPHR.Size = new System.Drawing.Size(204, 20);
            this.mnuEPHR.Text = "Emergency Personal Health Record";
            this.mnuEPHR.Click += new System.EventHandler(this.mnuEPHR_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(60, 20);
            this.mnuLogout.Text = "Log out";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 503);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Heath Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicalDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuCPHR;
        private System.Windows.Forms.ToolStripMenuItem mnuEPHR;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonalDetails;
    }
}