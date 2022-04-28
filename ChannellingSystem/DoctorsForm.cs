using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ChannellingSystem.Services;

namespace ChannellingSystem
{
    public partial class DoctorsForm : Form
    {
        DoctorService dservice = new DoctorService();
        DB_Connection dbCon = new DB_Connection();
        public MySqlConnection sc;
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            createDoctor();
            loadDoctor();

            MessageBox.Show("Save Successful");

            Clear();
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            updateDoctor();
            loadDoctor();
            MessageBox.Show("Update Successful");

            Clear();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            deleteDoctor();
            loadDoctor();
            MessageBox.Show("Delete Successful");

            Clear();
        }

        public void createDoctor()
        {
            dservice.doctor_id = txtDoctorID.Text;
            dservice.first_name = txtDoctorFName.Text;
            dservice.last_name = txtDoctorLName.Text;
            dservice.fees = txtDoctorFee.Text;
            dservice.gender = cmbGender.Text;
            dservice.special_in = txtDoctorSpecialIN.Text;
            dservice.Create_doctor();
        }

        public void updateDoctor()
        {
            dservice.doctor_id = txtDoctorID.Text;
            dservice.first_name = txtDoctorFName.Text;
            dservice.last_name = txtDoctorLName.Text;
            dservice.fees = txtDoctorFee.Text;
            dservice.gender = cmbGender.Text;
            dservice.special_in = txtDoctorSpecialIN.Text;
            dservice.Update_doctor();
        }

        public void loadDoctor()
        {
            grdDoctors.DataSource = null;
            dservice.Read_doctor();
            grdDoctors.DataSource = dservice.dt;
        }

        public void deleteDoctor()
        {
            dservice.id = txtDoctorID.Text;
            dservice.Delete_doctor();
        }


        private void grdDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            try
            {
                if (grdDoctors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtDoctorID.Text = (grdDoctors.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtDoctorFName.Text = (grdDoctors.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtDoctorLName.Text = (grdDoctors.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtDoctorFee.Text = (grdDoctors.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cmbGender.Text = (grdDoctors.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtDoctorSpecialIN.Text = (grdDoctors.Rows[e.RowIndex].Cells[6].Value.ToString());

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dont Click the Header");
            }
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            loadDoctor();
        }


        public void Clear()
        {
            txtDoctorID.Text = "";
            txtDoctorFName.Text = "";
            txtDoctorLName.Text = "";
            txtDoctorFee.Text = "";
            cmbGender.Text = "";
            txtDoctorSpecialIN.Text = "";
        }

        private void txtSearchDoctor_TextChanged(object sender, EventArgs e)
        {
            sc = dbCon.con;
            sc.Open();

            MySqlDataAdapter adapt = new MySqlDataAdapter("select * from doctor where doctor_id like '" + txtSearchDoctor.Text + "%' or first_name like '" + txtSearchDoctor.Text + "%' or last_name like '" + txtSearchDoctor.Text + "%' or fees like '" + txtSearchDoctor.Text + "%' or gender like '" + txtSearchDoctor.Text + "%' or special_in like '" + txtSearchDoctor.Text + "%' ", sc);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            grdDoctors.DataSource = dt;
            sc.Close();
        }
    }
}
