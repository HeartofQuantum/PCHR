using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace PCHR
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private string Gender;


        //Whenever someone clicks the accept button creates new patient data and inserts it into the database
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (IsValidGender(rdoMale.Checked) || IsValidGender(rdoFemale.Checked))
                {
                    if (IsValidPassword(txtPassword.Text, txtConfirmPassword.Text))
                    {
                        Patient newPatient = new Patient();
                        this.PutPatientData(newPatient);
                        try
                        {
                            PatientDB.AddPatient(newPatient);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                }
            }
        }
        // makes sure there all the fields a re filled.
        private bool IsValidData()
        {
            return
                 Validator.IsPresent(txtUsername) &&
                 Validator.IsPresent(txtPassword) &&
                 Validator.IsPresent(txtConfirmPassword) &&
                 Validator.IsPresent(txtIdNumber) &&
                 Validator.IsPresent(cboTitle) &&
                 Validator.IsPresent(txtInitials) &&
                 Validator.IsPresent(txtLName) &&
                 Validator.IsPresent(txtFName) &&
                 Validator.IsPresent(rdoFemale) ||
                 Validator.IsPresent(rdoMale);
        }


        // checks to see if the password is valid
        private bool IsValidPassword(string pass, string cPass)
        {
            pass = txtPassword.Text;
            cPass = txtConfirmPassword.Text;
            if (pass == cPass && cPass.Length > 6) return true;
            else return false;
        }

        //checks to see if the gender rdo buttons are checked
        private bool IsValidGender(bool gender)
        {
            if (rdoMale.Checked)
            {
                Gender = rdoMale.Text;
                return true;
            }
            else if (rdoFemale.Checked)
            {
                Gender = rdoFemale.Text;
                return true;
            }
            else { return false; }

        }

        // puts data to the Patient object
        private void PutPatientData(Patient patient)
        {
            //generates a new id everytime the method is called 
            patient.PATIENT_ID = Guid.NewGuid().ToString("N").Substring(0, 7);
            patient.LAST_NAME = txtLName.Text;
            patient.FIRST_NAME = txtFName.Text;
            patient.DATE_Of_BIRTH = dateOfBirth.Value.Date;
            patient.PRIMARY_ID = txtIdNumber.Text;
            patient.USERNAME = txtUsername.Text;
            patient.PWORD = txtConfirmPassword.Text;
            patient.TITLE = this.cboTitle.GetItemText(this.cboTitle.SelectedItem);
            patient.GENDER = Gender;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpPersonal_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
 }

