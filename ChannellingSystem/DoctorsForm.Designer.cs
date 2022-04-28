namespace ChannellingSystem
{
    partial class DoctorsForm
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
            System.Windows.Forms.Button btnEditDoctor;
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.grdDoctors = new System.Windows.Forms.DataGridView();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.txtDoctorSpecialIN = new System.Windows.Forms.TextBox();
            this.txtDoctorLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctorFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorFee = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            btnEditDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditDoctor
            // 
            btnEditDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnEditDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEditDoctor.ForeColor = System.Drawing.Color.White;
            btnEditDoctor.Location = new System.Drawing.Point(211, 197);
            btnEditDoctor.Name = "btnEditDoctor";
            btnEditDoctor.Size = new System.Drawing.Size(137, 37);
            btnEditDoctor.TabIndex = 60;
            btnEditDoctor.Text = "Update";
            btnEditDoctor.UseVisualStyleBackColor = false;
            btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(389, 197);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(137, 37);
            this.btnDeleteDoctor.TabIndex = 61;
            this.btnDeleteDoctor.Text = "Delete";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.Lime;
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.Location = new System.Drawing.Point(34, 197);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(137, 37);
            this.btnAddDoctor.TabIndex = 59;
            this.btnAddDoctor.Text = "Add";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(497, 86);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 21);
            this.cmbGender.TabIndex = 58;
            // 
            // grdDoctors
            // 
            this.grdDoctors.AllowUserToAddRows = false;
            this.grdDoctors.AllowUserToDeleteRows = false;
            this.grdDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoctors.Location = new System.Drawing.Point(34, 241);
            this.grdDoctors.Name = "grdDoctors";
            this.grdDoctors.ReadOnly = true;
            this.grdDoctors.Size = new System.Drawing.Size(893, 380);
            this.grdDoctors.TabIndex = 57;
            this.grdDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctors_CellContentClick);
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Location = new System.Drawing.Point(709, 207);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(218, 20);
            this.txtSearchDoctor.TabIndex = 56;
            this.txtSearchDoctor.TextChanged += new System.EventHandler(this.txtSearchDoctor_TextChanged);
            // 
            // txtDoctorSpecialIN
            // 
            this.txtDoctorSpecialIN.Location = new System.Drawing.Point(497, 116);
            this.txtDoctorSpecialIN.Name = "txtDoctorSpecialIN";
            this.txtDoctorSpecialIN.Size = new System.Drawing.Size(210, 20);
            this.txtDoctorSpecialIN.TabIndex = 55;
            // 
            // txtDoctorLName
            // 
            this.txtDoctorLName.Location = new System.Drawing.Point(105, 113);
            this.txtDoctorLName.Name = "txtDoctorLName";
            this.txtDoctorLName.Size = new System.Drawing.Size(314, 20);
            this.txtDoctorLName.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Special IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Last Name";
            // 
            // txtDoctorFName
            // 
            this.txtDoctorFName.Location = new System.Drawing.Point(105, 86);
            this.txtDoctorFName.Name = "txtDoctorFName";
            this.txtDoctorFName.Size = new System.Drawing.Size(314, 20);
            this.txtDoctorFName.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "First Name";
            // 
            // txtDoctorFee
            // 
            this.txtDoctorFee.Location = new System.Drawing.Point(497, 60);
            this.txtDoctorFee.Name = "txtDoctorFee";
            this.txtDoctorFee.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorFee.TabIndex = 51;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(105, 60);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorID.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(410, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 50;
            this.label3.Text = "Doctors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doctor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Search";
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 624);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(btnEditDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.grdDoctors);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.txtDoctorSpecialIN);
            this.Controls.Add(this.txtDoctorLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoctorFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoctorFee);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DataGridView grdDoctors;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.TextBox txtDoctorSpecialIN;
        private System.Windows.Forms.TextBox txtDoctorLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoctorFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorFee;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}