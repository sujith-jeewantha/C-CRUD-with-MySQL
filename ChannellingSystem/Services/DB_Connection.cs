using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ChannellingSystem.Services
{
    public class DB_Connection
    {

        public MySqlConnection con;
        public MySqlDataAdapter adapter;
        public MySqlDataReader reader;
        public MySqlCommand cmd;


        public DB_Connection()
        {
            string host = "localhost";
            string db = "channelling_db";
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource = " + host + "; port =" + port + "; database  =" + db + "; username =" + user + "; password =" + pass + "; SslMode=none";

            con = new MySqlConnection(constring);
        }

    }
}
