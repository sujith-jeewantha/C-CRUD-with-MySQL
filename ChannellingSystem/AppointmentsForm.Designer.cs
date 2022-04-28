namespace ChannellingSystem
{
    partial class AppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAppoinments = new System.Windows.Forms.Button();
            this.btnEditAppoinments = new System.Windows.Forms.Button();
            this.btnAddAppoinments = new System.Windows.Forms.Button();
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.cmbDoctorID = new System.Windows.Forms.ComboBox();
            this.grdAppoinments = new System.Windows.Forms.DataGridView();
            this.txtSearchAppinment = new System.Windows.Forms.TextBox();
            this.txtAppoinmentDesease = new System.Windows.Forms.TextBox();
            this.txtAppoinmentFee = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtAppoinmentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppoinments)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime.Location = new System.Drawing.Point(127, 131);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpTime.TabIndex = 52;
            this.dtpTime.Value = new System.DateTime(2021, 8, 9, 0, 3, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(127, 98);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 51;
            this.dtpDate.Value = new System.DateTime(2021, 8, 9, 0, 0, 0, 0);
            // 
            // btnDeleteAppoinments
            // 
            this.btnDeleteAppoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAppoinments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAppoinments.Location = new System.Drawing.Point(388, 199);
            this.btnDeleteAppoinments.Name = "btnDeleteAppoinments";
            this.btnDeleteAppoinments.Size = new System.Drawing.Size(137, 33);
            this.btnDeleteAppoinments.TabIndex = 49;
            this.btnDeleteAppoinments.Text = "Delete";
            this.btnDeleteAppoinments.UseVisualStyleBackColor = false;
            this.btnDeleteAppoinments.Click += new System.EventHandler(this.btnDeleteAppoinments_Click);
            // 
            // btnEditAppoinments
            // 
            this.btnEditAppoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditAppoinments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnEditAppoinments.Location = new System.Drawing.Point(210, 199);
            this.btnEditAppoinments.Name = "btnEditAppoinments";
            this.btnEditAppoinments.Size = new System.Drawing.Size(137, 33);
            this.btnEditAppoinments.TabIndex = 48;
            this.btnEditAppoinments.Text = "Update";
            this.btnEditAppoinments.UseVisualStyleBackColor = false;
            this.btnEditAppoinments.Click += new System.EventHandler(this.btnEditAppoinments_Click);
            // 
            // btnAddAppoinments
            // 
            this.btnAddAppoinments.BackColor = System.Drawing.Color.Lime;
            this.btnAddAppoinments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnAddAppoinments.Location = new System.Drawing.Point(34, 199);
            this.btnAddAppoinments.Name = "btnAddAppoinments";
            this.btnAddAppoinments.Size = new System.Drawing.Size(137, 33);
            this.btnAddAppoinments.TabIndex = 47;
            this.btnAddAppoinments.Text = "Add";
            this.btnAddAppoinments.UseVisualStyleBackColor = false;
            this.btnAddAppoinments.Click += new System.EventHandler(this.btnAddAppoinments_Click);
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Items.AddRange(new object[] {
            "PT001",
            "PT002",
            "PT003",
            "PT004"});
            this.cmbPatientID.Location = new System.Drawing.Point(344, 66);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(100, 21);
            this.cmbPatientID.TabIndex = 46;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.FormattingEnabled = true;
            this.cmbDoctorID.Items.AddRange(new object[] {
            "DT001",
            "DT002",
            "DT003",
            "DT004"});
            this.cmbDoctorID.Location = new System.Drawing.Point(344, 130);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(100, 21);
            this.cmbDoctorID.TabIndex = 45;
            this.cmbDoctorID.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorID_SelectedIndexChanged);
            // 
            // grdAppoinments
            // 
            this.grdAppoinments.AllowUserToAddRows = false;
            this.grdAppoinments.AllowUserToDeleteRows = false;
            this.grdAppoinments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppoinments.Location = new System.Drawing.Point(34, 239);
            this.grdAppoinments.Name = "grdAppoinments";
            this.grdAppoinments.ReadOnly = true;
            this.grdAppoinments.Size = new System.Drawing.Size(893, 380);
            this.grdAppoinments.TabIndex = 44;
            this.grdAppoinments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAppoinments_CellContentClick);
            // 
            // txtSearchAppinment
            // 
            this.txtSearchAppinment.Location = new System.Drawing.Point(709, 207);
            this.txtSearchAppinment.Name = "txtSearchAppinment";
            this.txtSearchAppinment.Size = new System.Drawing.Size(218, 20);
            this.txtSearchAppinment.TabIndex = 41;
            this.txtSearchAppinment.TextChanged += new System.EventHandler(this.txtSearchAppinment_TextChanged);
            // 
            // txtAppoinmentDesease
            // 
            this.txtAppoinmentDesease.Location = new System.Drawing.Point(610, 133);
            this.txtAppoinmentDesease.Name = "txtAppoinmentDesease";
            this.txtAppoinmentDesease.Size = new System.Drawing.Size(213, 20);
            this.txtAppoinmentDesease.TabIndex = 39;
            // 
            // txtAppoinmentFee
            // 
            this.txtAppoinmentFee.Location = new System.Drawing.Point(610, 100);
            this.txtAppoinmentFee.Name = "txtAppoinmentFee";
            this.txtAppoinmentFee.Size = new System.Drawing.Size(119, 20);
            this.txtAppoinmentFee.TabIndex = 40;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(610, 67);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(119, 20);
            this.txtDoctor.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Patient ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Disease";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Doctor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(344, 99);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 38;
            // 
            // txtAppoinmentID
            // 
            this.txtAppoinmentID.Location = new System.Drawing.Point(127, 67);
            this.txtAppoinmentID.Name = "txtAppoinmentID";
            this.txtAppoinmentID.Size = new System.Drawing.Size(100, 20);
            this.txtAppoinmentID.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(410, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Appoinments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Appoinmant ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "Search";
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 624);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnDeleteAppoinments);
            this.Controls.Add(this.btnEditAppoinments);
            this.Controls.Add(this.btnAddAppoinments);
            this.Controls.Add(this.cmbPatientID);
            this.Controls.Add(this.cmbDoctorID);
            this.Controls.Add(this.grdAppoinments);
            this.Controls.Add(this.txtSearchAppinment);
            this.Controls.Add(this.txtAppoinmentDesease);
            this.Controls.Add(this.txtAppoinmentFee);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.txtAppoinmentID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoinments";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAppoinments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnDeleteAppoinments;
        private System.Windows.Forms.Button btnEditAppoinments;
        private System.Windows.Forms.Button btnAddAppoinments;
        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.ComboBox cmbDoctorID;
        private System.Windows.Forms.DataGridView grdAppoinments;
        private System.Windows.Forms.TextBox txtSearchAppinment;
        private System.Windows.Forms.TextBox txtAppoinmentDesease;
        private System.Windows.Forms.TextBox txtAppoinmentFee;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtAppoinmentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}