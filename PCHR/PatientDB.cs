using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PCHR
{
    public static class PatientDB
    {
        private const string Dir = @"C:\Users\Cody\Desktop\PCHR\PCHR";
        private const string PATH = Dir + "Patients.txt";

        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();

            //create text file
            StreamReader InText = new StreamReader(new FileStream(PATH, FileMode.Open, FileAccess.Read));

            while (InText.Peek() != -1)
            {
                string row = InText.ReadLine();
                string[] columns = row.Split('|');
                Patient patient = new Patient();
                patient.PatientID = Convert.ToInt32(columns[0]);

                /*patient.FName = columns[1];
                patient.LName = columns[2];
                patient.LName = columns[3];
                patient.DOB   = Convert.ToString(columns[4]);
                patient.Street = columns[5];
                patient.City = columns[6];
                patient.State = columns[7];
                patient.Zip = columns[8];
                patient.Home = columns[9];
                patient.Mobile = columns[10];
                patient.PrimaryID = Convert.ToInt32(columns[11]);*/

            }

            InText.Close();
            return patients;
        }
    }
}
