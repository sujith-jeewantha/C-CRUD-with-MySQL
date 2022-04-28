using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChannellingSystem.Services;

namespace ChannellingSystem
{
    public partial class MainForm : Form
    {
        AppoinmentService aservice = new AppoinmentService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm dForm = new DoctorsForm();
            dForm.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointmentsForm aForm = new AppointmentsForm();
            aForm.Show();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm pForm = new PatientsForm();
            pForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadAppointment();
        }

        public void loadAppointment()
        {
            grdTodayAppoinments.DataSource = null;
            aservice.Read_appoinment();
            grdTodayAppoinments.DataSource = aservice.dt;

        }

    }
}
