using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHR
{
    public class Patient
    {
        public Patient() { }

        public Patient(string PATIENT_ID)
        {
            this.PATIENT_ID = PATIENT_ID;
        }

        public string PATIENT_ID { get; set; }

        public string FIRST_NAME { get; set; }

        public string LAST_NAME { get; set; }

        public DateTime DATE_Of_BIRTH { get; set; }

        public string ADDRESS_STREET { get; set; }

        public string ADDRESS_CITY { get; set; }

        public string ADDRESS_STATE { get; set; }

        public string ADDRESS_ZIP { get; set; }

        public string PHONE_HOME { get; set; }

        public string PHONE_MOBILE { get; set; }

        public string PRIMARY_ID { get; set; }

        public string USERNAME { get; set; }

        public string PWORD { get; set; }

        public string TITLE { get; set; }

        public string GENDER { get; set; }
    }
}