using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ChannellingSystem.Services
{
    class AppoinmentService:DB_Connection
    {
        //PROPERTIES

        public string appoinment_id { set; get; }
        public string date { set; get; }
        public string time { set; get; }
        public string patient_id { set; get; }
        public string patient_name { set; get; }
        public string doctor_id { set; get; }
        public string doctor_name { set; get; }
        public string fees { set; get; }
        public string disease { set; get; }
        public string status { set; get; }

        //FOR ID

        public string id { set; get; }

        //READ PROPERTIES

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE FUNCTION
        public void Create_appoinment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "INSERT INTO `appoinment`( `appoinment_id`, `date`, `time`, `patient_id`, `patient_name`, `doctor_id`, `doctor_name`, `fees`, `disease`) VALUES(@appoinmentid, @date, @time, @patientid, @patientname, @doctorid, @doctorname, @fee, @disease) ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@appoinmentid", MySqlDbType.VarChar).Value = appoinment_id;
                cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
                cmd.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;
                cmd.Parameters.Add("@patientid", MySqlDbType.VarChar).Value = patient_id;
                cmd.Parameters.Add("@patientname", MySqlDbType.VarChar).Value = patient_name;
                cmd.Parameters.Add("@doctorid", MySqlDbType.VarChar).Value = doctor_id;
                cmd.Parameters.Add("@doctorname", MySqlDbType.VarChar).Value = doctor_name;
                cmd.Parameters.Add("@fee", MySqlDbType.VarChar).Value = fees;
                cmd.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        //UPDATE FUNCTION
        public void Update_appoinment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "UPDATE appoinment SET appoinment_id=@appoinmentid, date=@date, time=@time, patient_id=@patientid, patient_name=@patientname, doctor_id=@doctorid, doctor_name=@doctorname, fees=@fee, disease=@disease WHERE id=@id ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@appoinmentid", MySqlDbType.VarChar).Value = appoinment_id;
                cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
                cmd.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;
                cmd.Parameters.Add("@patientid", MySqlDbType.VarChar).Value = patient_id;
                cmd.Parameters.Add("@patientname", MySqlDbType.VarChar).Value = patient_name;
                cmd.Parameters.Add("@doctorid", MySqlDbType.VarChar).Value = doctor_id;
                cmd.Parameters.Add("@doctorname", MySqlDbType.VarChar).Value = doctor_name;
                cmd.Parameters.Add("@fee", MySqlDbType.VarChar).Value = fees;
                cmd.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //DELETE FUNCTION
        public void Delete_appoinment()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "DELETE FROM appoinment WHERE appoinment_id=@appoinmentid ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@appoinmentid", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //READ FUNCTION
        public void Read_appoinment()
        {
            dt.Clear();
            string query = "SELECT * from `appoinment` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        //READ FUNCTION
        public void Read_today_appoinment()
        {
            dt.Clear();
            string query = "SELECT * from `appoinment` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        //READ FUNCTION
        public void Read_doctor_id()
        {
            dt.Clear();
            string query = "SELECT doctor_id from `doctor` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

        //READ FUNCTION
        public void Read_patient_id()
        {
            dt.Clear();
            string query = "SELECT patient_id from `patient` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

    }
}
