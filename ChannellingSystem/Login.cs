using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ChannellingSystem.Services;

namespace ChannellingSystem
{
    public partial class Login : Form
    {
        DB_Connection dbCon = new DB_Connection();
        public MySqlConnection sc;
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
                {

                    sc = dbCon.con;
                    //sc.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM user WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'", sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Login credentials, Please check username and password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Please fill username and password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
