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

    public partial class AppointmentsForm : Form
    {
        AppoinmentService aservice = new AppoinmentService();
        DB_Connection dbCon = new DB_Connection();
        public MySqlConnection sc;
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            cmbDoctorID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatientID.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpDate.CustomFormat = "dd-MM-yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "hh:mm";
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            loadAppointment();
        }

        private void btnAddAppoinments_Click(object sender, EventArgs e)
        {
            createAppointment();
            loadAppointment();
            MessageBox.Show("Save Successful");

            Clear();
        }

        private void btnEditAppoinments_Click(object sender, EventArgs e)
        {
            updateAppointment();
            loadAppointment();
            MessageBox.Show("Update Successful");

            Clear();
        }


        private void btnDeleteAppoinments_Click(object sender, EventArgs e)
        {
            deleteAppointment();
            loadAppointment();
            MessageBox.Show("Delete Successful");

            Clear();
        }

        private void grdAppoinments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            try
            {
                if (grdAppoinments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtAppoinmentID.Text = (grdAppoinments.Rows[e.RowIndex].Cells[1].Value.ToString());
                    dtpDate.Text = (grdAppoinments.Rows[e.RowIndex].Cells[2].Value.ToString());
                    dtpTime.Text = (grdAppoinments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cmbPatientID.Text = (grdAppoinments.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtPatient.Text = (grdAppoinments.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cmbDoctorID.Text = (grdAppoinments.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txtDoctor.Text = (grdAppoinments.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txtAppoinmentFee.Text = (grdAppoinments.Rows[e.RowIndex].Cells[8].Value.ToString());
                    txtAppoinmentDesease.Text = (grdAppoinments.Rows[e.RowIndex].Cells[9].Value.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dont Click the Header");
            }
        }

        public void createAppointment()
        {
            aservice.appoinment_id = txtAppoinmentID.Text;
            aservice.date = dtpDate.Value.Date.ToString("yyyyMMdd");
            aservice.time = dtpTime.Value.Date.ToString("hh:mm");
            aservice.patient_id = cmbPatientID.Text;
            aservice.patient_name = txtPatient.Text;
            aservice.doctor_id = cmbDoctorID.Text;
            aservice.doctor_name = txtDoctor.Text;
            aservice.fees = txtAppoinmentFee.Text;
            aservice.disease = txtAppoinmentDesease.Text;
            aservice.Create_appoinment();
        }

        public void loadAppointment()
        {
            grdAppoinments.DataSource = null;
            aservice.Read_appoinment();
            grdAppoinments.DataSource = aservice.dt;
        }

        public void updateAppointment()
        {
            aservice.appoinment_id = txtAppoinmentID.Text;
            aservice.date = dtpDate.Text;
            aservice.time = dtpTime.Text;
            aservice.patient_id = cmbPatientID.Text;
            aservice.patient_name = txtPatient.Text;
            aservice.doctor_id = cmbDoctorID.Text;
            aservice.doctor_name = txtDoctor.Text;
            aservice.fees = txtAppoinmentFee.Text;
            aservice.disease = txtAppoinmentDesease.Text;
            aservice.Update_appoinment();
        }

        public void deleteAppointment()
        {
            aservice.id = txtAppoinmentID.Text;
            aservice.Delete_appoinment();
        }


        public void Clear()
        {
            txtAppoinmentID.Text = "";
            dtpDate.Text = "";
            dtpTime.Text = "";
            cmbPatientID.Text = "";
            txtPatient.Text = "";
            cmbDoctorID.Text = "";
            txtDoctor.Text = "";
            txtAppoinmentFee.Text = "";
            txtAppoinmentDesease.Text = "";
        }

        private void txtSearchAppinment_TextChanged(object sender, EventArgs e)
        {
            sc = dbCon.con;
            sc.Open();

            MySqlDataAdapter adapt = new MySqlDataAdapter("select * from appoinment where appoinment_id like '" + txtSearchAppinment.Text + "%' or patient_id like '" + txtSearchAppinment.Text + "%' or patient_name like '" + txtSearchAppinment.Text + "%' or doctor_id like '" + txtSearchAppinment.Text + "%' or doctor_name like '" + txtSearchAppinment.Text + "%' or disease like '" + txtSearchAppinment.Text + "%' ", sc);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            grdAppoinments.DataSource = dt;
            sc.Close();
        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            sc = dbCon.con;

            string query = "SELECT first_name FROM patient WHERE patient_id = '" + cmbPatientID.Text + "' ";
            //string query = "SELECT first_name FROM patient WHERE patient_id = 'P003' ";
            MySqlCommand cmd = new MySqlCommand(query, sc);
            MySqlDataReader dbr;
            try
            {
                sc.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {

                    string firstName = (string)dbr["first_name"];

                    txtPatient.Text = firstName;

                }
                sc.Close();
            }
            catch (Exception es)
            {

            }

        }

   
        private void cmbDoctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            sc = dbCon.con;

            string query = "SELECT first_name FROM doctor WHERE doctor_id = '" + cmbDoctorID.Text + "' ";
            //string query = "SELECT first_name FROM doctor WHERE doctor_id = 'D002' ";
            MySqlCommand cmd = new MySqlCommand(query, sc);
            MySqlDataReader dbr;
            try
            {
                sc.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {

                    string firstName = (string)dbr["first_name"];

                    txtDoctor.Text = firstName;

                }
                sc.Close();
            }
            catch (Exception es)
            {

            }
        }
    }
}