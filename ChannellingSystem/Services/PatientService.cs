using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ChannellingSystem.Services
{
    class PatientService:DB_Connection
    {
        //PROPERTIES

        public string patient_id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string age { set; get; }
        public string gender { set; get; }
        public string disease { set; get; }

        //FOR ID

        public string id { set; get; }

        //READ PROPERTIES

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE FUNCTION
        public void Create_patient()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "INSERT INTO `patient`( `patient_id`, `first_name`, `last_name`, `age`, `gender`, `disease`) VALUES(@patientid, @firstname, @lastname, @age, @gender, @disease) ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@patientid", MySqlDbType.VarChar).Value = patient_id;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = first_name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        //UPDATE FUNCTION
        public void Update_patient()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "UPDATE patient SET patient_id=@patientid, first_name=@firstname, last_name=@lastname, age=@age, gender=@gender, disease=@disease  WHERE id=@id ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@patientid", MySqlDbType.VarChar).Value = patient_id;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = first_name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //DELETE FUNCTION
        public void Delete_patient()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "DELETE FROM patient WHERE patient_id=@patientid ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@patientid", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //READ FUNCTION
        public void Read_patient()
        {
            dt.Clear();
            string query = "SELECT * from `patient` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }
}
