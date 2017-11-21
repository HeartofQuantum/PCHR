namespace PCHR
{
    partial class frmRegistration
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtConfrimPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtConfrimPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.lblConfirmPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Location = new System.Drawing.Point(31, 43);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(567, 132);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Details";
            this.grpLogin.Enter += new System.EventHandler(this.grpLogin_Enter);
            // 
            // txtConfrimPassword
            // 
            this.txtConfrimPassword.Location = new System.Drawing.Point(197, 91);
            this.txtConfrimPassword.Name = "txtConfrimPassword";
            this.txtConfrimPassword.Size = new System.Drawing.Size(253, 20);
            this.txtConfrimPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(197, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(79, 94);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(79, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(79, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.rdoFemale);
            this.grpPersonal.Controls.Add(this.cboTitle);
            this.grpPersonal.Controls.Add(this.rdoMale);
            this.grpPersonal.Controls.Add(this.dateTimePicker1);
            this.grpPersonal.Controls.Add(this.txtInitials);
            this.grpPersonal.Controls.Add(this.txtFName);
            this.grpPersonal.Controls.Add(this.txtLName);
            this.grpPersonal.Controls.Add(this.txtIdNumber);
            this.grpPersonal.Controls.Add(this.lblInitials);
            this.grpPersonal.Controls.Add(this.lblGender);
            this.grpPersonal.Controls.Add(this.lblDOB);
            this.grpPersonal.Controls.Add(this.lblFName);
            this.grpPersonal.Controls.Add(this.lblLName);
            this.grpPersonal.Controls.Add(this.lblTitle);
            this.grpPersonal.Controls.Add(this.lblIdNumber);
            this.grpPersonal.Location = new System.Drawing.Point(31, 191);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(567, 276);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Details";
            this.grpPersonal.Enter += new System.EventHandler(this.grpPersonal_Enter);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(296, 209);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 19;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.cboTitle.Location = new System.Drawing.Point(197, 76);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(105, 21);
            this.cboTitle.TabIndex = 18;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(197, 209);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 16;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(350, 76);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 14;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(197, 144);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(253, 20);
            this.txtFName.TabIndex = 13;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(197, 112);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(253, 20);
            this.txtLName.TabIndex = 12;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(197, 41);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(253, 20);
            this.txtIdNumber.TabIndex = 7;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(308, 79);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(36, 13);
            this.lblInitials.TabIndex = 10;
            this.lblInitials.Text = "Initials";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(79, 211);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(79, 179);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(79, 147);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(79, 112);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(79, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(79, 44);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(81, 13);
            this.lblIdNumber.TabIndex = 4;
            this.lblIdNumber.Text = "Identity Number";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(449, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(31, 12);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(618, 13);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Please enter all the following details to register.";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 539);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpLogin);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtConfrimPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
    }
}