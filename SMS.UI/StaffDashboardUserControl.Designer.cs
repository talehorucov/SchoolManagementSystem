namespace SMS.UI
{
    partial class StaffDashboardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboardUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbContactInformation = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStudentInformation = new System.Windows.Forms.GroupBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbContactInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.gbStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.gbContactInformation);
            this.panel1.Controls.Add(this.cmbClasses);
            this.panel1.Controls.Add(this.dgvDashboard);
            this.panel1.Controls.Add(this.gbStudentInformation);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(251, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 680);
            this.panel1.TabIndex = 0;
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbContactInformation.Controls.Add(this.label5);
            this.gbContactInformation.Controls.Add(this.lblAddress);
            this.gbContactInformation.Controls.Add(this.lblContactNo);
            this.gbContactInformation.Controls.Add(this.label10);
            this.gbContactInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbContactInformation.Location = new System.Drawing.Point(53, 452);
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.Size = new System.Drawing.Size(332, 141);
            this.gbContactInformation.TabIndex = 20;
            this.gbContactInformation.TabStop = false;
            this.gbContactInformation.Text = "Contact Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address :";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(101, 64);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(206, 60);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "address";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactNo.Location = new System.Drawing.Point(101, 37);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(68, 17);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "contactNo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Contact No :";
            // 
            // cmbClasses
            // 
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(900, 269);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(137, 25);
            this.cmbClasses.TabIndex = 19;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Firstname});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDashboard.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashboard.Location = new System.Drawing.Point(427, 300);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDashboard.Size = new System.Drawing.Size(610, 293);
            this.dgvDashboard.TabIndex = 18;
            // 
            // Row
            // 
            this.Row.FillWeight = 30F;
            this.Row.HeaderText = "Row";
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Student";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // gbStudentInformation
            // 
            this.gbStudentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbStudentInformation.Controls.Add(this.lblSubject);
            this.gbStudentInformation.Controls.Add(this.label4);
            this.gbStudentInformation.Controls.Add(this.lblBornDate);
            this.gbStudentInformation.Controls.Add(this.label3);
            this.gbStudentInformation.Controls.Add(this.lblFirstname);
            this.gbStudentInformation.Controls.Add(this.label2);
            this.gbStudentInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStudentInformation.Location = new System.Drawing.Point(53, 300);
            this.gbStudentInformation.Name = "gbStudentInformation";
            this.gbStudentInformation.Size = new System.Drawing.Size(332, 127);
            this.gbStudentInformation.TabIndex = 17;
            this.gbStudentInformation.TabStop = false;
            this.gbStudentInformation.Text = "Teacher Information";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubject.Location = new System.Drawing.Point(101, 91);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 17);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject :";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBornDate.Location = new System.Drawing.Point(101, 64);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(63, 17);
            this.lblBornDate.TabIndex = 4;
            this.lblBornDate.Text = "bornDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Born :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstname.Location = new System.Drawing.Point(101, 37);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(62, 17);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(142, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 154);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // StaffDashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "StaffDashboardUserControl";
            this.Size = new System.Drawing.Size(1323, 745);
            this.Load += new System.EventHandler(this.StaffDashboardUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.gbContactInformation.ResumeLayout(false);
            this.gbContactInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.gbStudentInformation.ResumeLayout(false);
            this.gbStudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbContactInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.GroupBox gbStudentInformation;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
