using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHR
{
    public class Patient
    {

        //private vaibles
        private int patientID { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        /*
        public string LName { get; set; }
        public string FName { get; set; }
        public DateTime DOB { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Home { get; set; }
        public string Mobile { get; set; }
        public int PrimaryID { get; set; }
        */

        //Constructors
        public Patient() { }

        public Patient(int PatientID, string username, string password)
        {
            this.PatientID = patientID;
            this.Username = username;
            this.Password = password;
        }

        public int PatientID
        {
            get
            {
                return patientID;
            }
            set
            {
                patientID = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

    }
}
