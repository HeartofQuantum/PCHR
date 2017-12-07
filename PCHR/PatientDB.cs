using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PCHR
{
    class PatientDB
    {
        public static Patient GetPatient(string patientID)
        {
            SqlConnection con = PCHRDB.GetConnection();
            string selectStatement = 
                "SELECT PATIENT_ID, LAST_NAME, FIRST_NAME, DATE_Of_BIRTH, ADDRESS_STREET, ADDRESS_CITY, ADDRESS_STATE, ADDRESS_ZIP, PHONE_HOME, PHONE_MOBILE, PRIMARY_ID, USERNAME, PWORD"
               + "FROM PATIENT_TBL "
               + "WHERE PATIENT_ID = @PATIENT_ID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader patientReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (patientReader.Read())
                {
                    Patient patient = new Patient();
                    patient.PATIENT_ID = patientReader["PATIENT_ID"].ToString();
                    patient.DATE_Of_BIRTH = (DateTime) patientReader["DATE_Of_BIRTH"];
                    patient.FIRST_NAME = patientReader["FIRST_NAME"].ToString();
                    patient.LAST_NAME = patientReader["LAST_NAME"].ToString();
                    patient.ADDRESS_STREET = patientReader["ADDRESS_STREET"].ToString();
                    patient.ADDRESS_CITY = patientReader["ADDRESS_CITY"].ToString();
                    patient.ADDRESS_STATE = patientReader["ADDRESS_STATE"].ToString();
                    patient.ADDRESS_ZIP = patientReader["ADDRESS_ZIP"].ToString();
                    patient.PHONE_HOME = patientReader["PHONE_HOME"].ToString();
                    patient.PHONE_MOBILE = patientReader["PHONE_MOBILE"].ToString();
                    patient.PHONE_HOME = patientReader["PHONE_HOME"].ToString();
                    patient.USERNAME = patientReader["USERNAME"].ToString();
                    patient.PWORD = patientReader["PWORD"].ToString();
                    patient.TITLE = patientReader["TITLE"].ToString();
                    patient.GENDER = patientReader["GENDER"].ToString();
                    return patient;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }

        public static Patient Login(string username, string password)
        {
            SqlConnection con = PCHRDB.GetConnection();
            string ValidPatient = "SELECT USERNAME, PWORD FROM PATIENT_TBL WHERE USERNAME = @USERNAME AND PWORD = @PWORD";
            SqlCommand selectCommand = new SqlCommand(ValidPatient, con);

            
            try
            {
                con.Open();
                selectCommand.Parameters.AddWithValue("@USERNAME", username);
                selectCommand.Parameters.AddWithValue("@PWORD", password);
                SqlDataReader patientReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                //Patient logPatient = new Patient(); 
                if (patientReader.Read())
                {
                    Patient youPatient = new Patient();
                    youPatient.USERNAME = patientReader["USERNAME"].ToString();
                    youPatient.PWORD = patientReader["PWORD"].ToString();
                    return youPatient;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }


        }
            
        

        public static bool UpdatePatient(Patient oldPatient, Patient newPatient)
        {
            SqlConnection con = PCHRDB.GetConnection();
            string updateStatement =
                "UPDATE PATIENT_TBL SET"
                + "PATIENT_ID = @NewPATIENT_ID,"
                + "DATE_OF_BIRTH = @NewDATE_OF_BIRTH"
                + "FIRST_NAME = @NewFIRST_NAME"
                + "LAST_NAME = @NewLAST_NAME"
                + "ADDRESS_STREET = @NewADDRESS_STREET"
                + "ADDRESS_CITY = @NewADDRESS_CITY"
                + "ADDRESS_STATE = @NewADDRESS_STATE"
                + "ADDRESS_ZIP = @NewADDRESS_ZIP"
                + "PHONE_HOME = @NewPHOME_HOME"
                + "PHONE_MOBILE = @NewPHONE_MOBILE"
                + "USERNAME = @NewUSERNAME"
                + "PWORD = @NewPWORD"
                + "TITLE = @NewTITLE"

                + "WHERE PATIENT_ID = @OldPATIENT_ID"
                
                + "AND DATE_OF_BIRTH = @OldDATE_OF_BIRTH"
                + "AND FIRST_NAME = @OldFIRST_NAME"
                + "AND LAST_NAME = @OldLAST_NAME"
                + "AND ADDRESS_STREET = @OldADDRESS_STREET"
                + "AND ADDRESS_CITY = @OldADDRESS_CITY"
                + "AND ADDRESS_STATE = @OldADDRESS_STATE"
                + "AND ADDRESS_ZIP = @OldADDRESS_ZIP"
                + "PHONE_HOME = @OldPHOME_HOME"
                + "PHONE_HOME = @OldPHOME_MOBILE"
                + "AND USERNAME = @OldUSERNAME"
                + "AND PWORD = @OldPWORD"
                + "AND TITLE = @OldTITLE";

            SqlCommand updateCommand = new SqlCommand(updateStatement, con);
            updateCommand.Parameters.AddWithValue("@NewPATIENT_ID", newPatient.PATIENT_ID);
            updateCommand.Parameters.AddWithValue("@NewDATE_OF_BIRTH", newPatient.DATE_Of_BIRTH);
            updateCommand.Parameters.AddWithValue("@NewFIRST_NAME", newPatient.FIRST_NAME);
            updateCommand.Parameters.AddWithValue("@NewLAST_NAME", newPatient.LAST_NAME);
            updateCommand.Parameters.AddWithValue("@NewADDRESS_STREET", newPatient.ADDRESS_STREET);
            updateCommand.Parameters.AddWithValue("@NewADDRESS_CITY", newPatient.ADDRESS_CITY);
            updateCommand.Parameters.AddWithValue("@NewADDRESS_STATE", newPatient.ADDRESS_STATE);
            updateCommand.Parameters.AddWithValue("@NewADDRESS_ZIP", newPatient.ADDRESS_ZIP);
            updateCommand.Parameters.AddWithValue("@NewPHONE_HOME", newPatient.PHONE_HOME);
            updateCommand.Parameters.AddWithValue("@NewPHONE_MOBILE", newPatient.PHONE_MOBILE);
            updateCommand.Parameters.AddWithValue("@NewUSERNAME", newPatient.USERNAME);
            updateCommand.Parameters.AddWithValue("@NewPWORD", newPatient.PWORD);
            updateCommand.Parameters.AddWithValue("@NewTITLE", newPatient.TITLE);

            updateCommand.Parameters.AddWithValue("@OldPATIENT_ID", oldPatient.PATIENT_ID);
            updateCommand.Parameters.AddWithValue("@OldDATE_OF_BIRTH", oldPatient.DATE_Of_BIRTH);
            updateCommand.Parameters.AddWithValue("@OldFIRST_NAME", oldPatient.FIRST_NAME);
            updateCommand.Parameters.AddWithValue("@OldLAST_NAME", oldPatient.LAST_NAME);
            updateCommand.Parameters.AddWithValue("@OldADDRESS_STREET", oldPatient.ADDRESS_STREET);
            updateCommand.Parameters.AddWithValue("@OldADDRESS_CITY", oldPatient.ADDRESS_CITY);
            updateCommand.Parameters.AddWithValue("@OldADDRESS_STATE", oldPatient.ADDRESS_STATE);
            updateCommand.Parameters.AddWithValue("@OldADDRESS_ZIP", oldPatient.ADDRESS_ZIP);
            updateCommand.Parameters.AddWithValue("@OldPHONE_HOME", oldPatient.PHONE_HOME);
            updateCommand.Parameters.AddWithValue("@OldPHONE_MOBILE", oldPatient.PHONE_MOBILE);
            updateCommand.Parameters.AddWithValue("@OldUSERNAME", oldPatient.USERNAME);
            updateCommand.Parameters.AddWithValue("@OldPWORD", oldPatient.PWORD);
            updateCommand.Parameters.AddWithValue("@OldTITLE", oldPatient.TITLE);

            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void AddPatient(Patient patient)
        {
            SqlConnection con = PCHRDB.GetConnection();

            string insertStatement = "INSERT INTO PATIENT_TBL " + "(PATIENT_ID, LAST_NAME, FIRST_NAME, DATE_Of_BIRTH, PRIMARY_ID, USERNAME, PWORD, TITLE, GENDER )"
            + " VALUES (@PATIENT_ID, @LAST_NAME, @FIRST_NAME, @DATE_Of_BIRTH, @PRIMARY_ID, @USERNAME, @PWORD, @TITLE, @GENDER)";
            //string patientID = Guid.NewGuid().ToString("N").Substring(0, 10);
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);

            insertCommand.Parameters.AddWithValue("@PATIENT_ID", patient.PATIENT_ID);
            insertCommand.Parameters.AddWithValue("@LAST_NAME", patient.LAST_NAME);
            insertCommand.Parameters.AddWithValue("@FIRST_NAME", patient.FIRST_NAME);
            insertCommand.Parameters.AddWithValue("@DATE_OF_BIRTH", patient.DATE_Of_BIRTH);
            insertCommand.Parameters.AddWithValue("@PRIMARY_ID", patient.PRIMARY_ID);
            insertCommand.Parameters.AddWithValue("@USERNAME", patient.USERNAME);
            insertCommand.Parameters.AddWithValue("@PWORD", patient.PWORD);
            insertCommand.Parameters.AddWithValue("@TITLE", patient.TITLE);
            insertCommand.Parameters.AddWithValue("@GENDER", patient.GENDER);
            try
            {
                con.Open();

                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('PATIENT_TBL') FROM PATIENT_TBL";
                SqlCommand selectCommand = new SqlCommand(selectStatement, con);
                selectCommand.ExecuteScalar();
                //string patientID = "000003"; 

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
