using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHR
{
    public class Patient
    {
 
        public int PatientID   { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }
        public string LName    { get; set; }
        public string FName    { get; set; }
        public DateTime DOB    { get; set; }
        public string Street   { get; set; }
        public string City     { get; set; }
        public string State    { get; set; }
        public string Zip      { get; set; }
        public string Home     { get; set; }
        public string Mobile   { get; set; }
        public int PrimaryID   { get; set; }
    }
}
