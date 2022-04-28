using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ChannellingSystem.Services
{
    class DoctorService: DB_Connection
    {

        //PROPERTIES

        public string doctor_id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string fees { set; get; }
        public string gender { set; get; }
        public string special_in { set; get; }

        //FOR ID

        public string id { set; get; }

        //READ PROPERTIES

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE FUNCTION
        public void Create_doctor()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "INSERT INTO `doctor`( `doctor_id`, `first_name`, `last_name`, `fees`, `gender`, `special_in`) VALUES(@doctorid, @firstname, @lastname, @fee, @gender, @specialin) ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@doctorid", MySqlDbType.VarChar).Value = doctor_id;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = first_name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@fee", MySqlDbType.VarChar).Value = fees;
                cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@specialin", MySqlDbType.VarChar).Value = special_in;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        //UPDATE FUNCTION
        public void Update_doctor()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "UPDATE doctor SET doctor_id=@doctorid, first_name=@firstname, last_name=@lastname, fees=@fee, gender=@gender, special_in=@specialin WHERE id=@id ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@doctorid", MySqlDbType.VarChar).Value = doctor_id;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = first_name;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = last_name;
                cmd.Parameters.Add("@fee", MySqlDbType.VarChar).Value = fees;
                cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@specialin", MySqlDbType.VarChar).Value = special_in;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //DELETE FUNCTION
        public void Delete_doctor()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())

            {
                cmd.CommandText = "DELETE FROM doctor WHERE doctor_id=@doctorid ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@doctorid", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //READ FUNCTION
        public void Read_doctor()
        {
            dt.Clear();
            string query = "SELECT * from `doctor` ";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }

    }
}
