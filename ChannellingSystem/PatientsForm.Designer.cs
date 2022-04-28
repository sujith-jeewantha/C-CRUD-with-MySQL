namespace ChannellingSystem
{
    partial class PatientsForm
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
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.cmbPatientGender = new System.Windows.Forms.ComboBox();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.txtPatientDisease = new System.Windows.Forms.TextBox();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.ForeColor = System.Drawing.Color.White;
            this.btnDeletePatient.Location = new System.Drawing.Point(381, 199);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(137, 35);
            this.btnDeletePatient.TabIndex = 42;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = false;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.ForeColor = System.Drawing.Color.White;
            this.btnEditPatient.Location = new System.Drawing.Point(210, 199);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(137, 35);
            this.btnEditPatient.TabIndex = 41;
            this.btnEditPatient.Text = "Update";
            this.btnEditPatient.UseVisualStyleBackColor = false;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(34, 199);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(137, 35);
            this.btnAddPatient.TabIndex = 40;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // cmbPatientGender
            // 
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbPatientGender.Location = new System.Drawing.Point(497, 86);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(100, 21);
            this.cmbPatientGender.TabIndex = 39;
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.AllowUserToDeleteRows = false;
            this.grdPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Location = new System.Drawing.Point(34, 241);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.ReadOnly = true;
            this.grdPatients.Size = new System.Drawing.Size(893, 380);
            this.grdPatients.TabIndex = 38;
            this.grdPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellContentClick);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(709, 213);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(218, 20);
            this.txtSearchPatient.TabIndex = 37;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // txtPatientDisease
            // 
            this.txtPatientDisease.Location = new System.Drawing.Point(497, 116);
            this.txtPatientDisease.Name = "txtPatientDisease";
            this.txtPatientDisease.Size = new System.Drawing.Size(210, 20);
            this.txtPatientDisease.TabIndex = 36;
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Location = new System.Drawing.Point(105, 113);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.Size = new System.Drawing.Size(314, 20);
            this.txtPatientLName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Disease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name";
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Location = new System.Drawing.Point(105, 86);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.Size = new System.Drawing.Size(314, 20);
            this.txtPatientFName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "First Name";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(497, 60);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(100, 20);
            this.txtPatientAge.TabIndex = 32;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(105, 60);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(153, 20);
            this.txtPatientID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(410, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Patients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patient ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Search";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 624);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.cmbPatientGender);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.txtPatientDisease);
            this.Controls.Add(this.txtPatientLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatientFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.TextBox txtPatientDisease;
        private System.Windows.Forms.TextBox txtPatientLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatientFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}