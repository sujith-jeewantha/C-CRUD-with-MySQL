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
    public partial class PatientsForm : Form
    {
        PatientService pservice = new PatientService();
        DB_Connection dbCon = new DB_Connection();
        public MySqlConnection sc;
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            cmbPatientGender.DropDownStyle = ComboBoxStyle.DropDownList;
            loadPatient();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            createPatient();
            loadPatient();
            MessageBox.Show("Save Successful");

            Clear();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            updatePatient();
            loadPatient();
            MessageBox.Show("Update Successful");

            Clear();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            deletePatient();
            loadPatient();
            MessageBox.Show("Delete Successful");

            Clear();
        }

      
        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            try
            {
                if (grdPatients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtPatientID.Text = (grdPatients.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtPatientFName.Text = (grdPatients.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtPatientLName.Text = (grdPatients.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtPatientAge.Text = (grdPatients.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cmbPatientGender.Text = (grdPatients.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtPatientDisease.Text = (grdPatients.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dont Click the Header");
            }
        }

        public void createPatient()
        {
            pservice.patient_id = txtPatientID.Text;
            pservice.first_name = txtPatientFName.Text;
            pservice.last_name = txtPatientLName.Text;
            pservice.age = txtPatientAge.Text;
            pservice.gender = cmbPatientGender.Text;
            pservice.disease = txtPatientDisease.Text;
            pservice.Create_patient();
        }

        public void updatePatient()
        {
            pservice.patient_id = txtPatientID.Text;
            pservice.first_name = txtPatientFName.Text;
            pservice.last_name = txtPatientLName.Text;
            pservice.age = txtPatientAge.Text;
            pservice.gender = cmbPatientGender.Text;
            pservice.disease = txtPatientDisease.Text;
            pservice.Update_patient();
        }

        public void loadPatient()
        {
            grdPatients.DataSource = null;
            pservice.Read_patient();
            grdPatients.DataSource = pservice.dt;
        }

        public void deletePatient()
        {
            pservice.id = txtPatientID.Text;
            pservice.Delete_patient();
        }

      
        public void Clear()
        {
            txtPatientID.Text = "";
            txtPatientFName.Text = "";
            txtPatientLName.Text = "";
            txtPatientAge.Text = "";
            cmbPatientGender.Text = "";
            txtPatientDisease.Text = "";
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            sc = dbCon.con;
            sc.Open();

            MySqlDataAdapter adapt = new MySqlDataAdapter("select * from patient where patient_id like '" + txtSearchPatient.Text + "%' or first_name like '" + txtSearchPatient.Text + "%' or last_name like '" + txtSearchPatient.Text + "%' or age like '" + txtSearchPatient.Text + "%' or gender like '" + txtSearchPatient.Text + "%' or disease like '" + txtSearchPatient.Text + "%' ", sc);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            grdPatients.DataSource = dt;
            sc.Close();
        }
    }
}
