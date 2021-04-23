namespace SMS.UI
{
    partial class AddSubjectFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDgvId = new System.Windows.Forms.Label();
            this.btnAdded = new System.Windows.Forms.Button();
            this.dgvDeleteSubjects = new System.Windows.Forms.DataGridView();
            this.dgvAddSubjects = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbtnExit = new SMS.UI.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(288, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unregistered";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(255, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 46);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDgvId
            // 
            this.lblDgvId.AutoSize = true;
            this.lblDgvId.Location = new System.Drawing.Point(203, 142);
            this.lblDgvId.Name = "lblDgvId";
            this.lblDgvId.Size = new System.Drawing.Size(35, 13);
            this.lblDgvId.TabIndex = 9;
            this.lblDgvId.Text = "label1";
            this.lblDgvId.Visible = false;
            // 
            // btnAdded
            // 
            this.btnAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdded.FlatAppearance.BorderSize = 0;
            this.btnAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdded.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdded.ForeColor = System.Drawing.Color.White;
            this.btnAdded.Location = new System.Drawing.Point(22, 341);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(154, 46);
            this.btnAdded.TabIndex = 8;
            this.btnAdded.Text = "Add";
            this.btnAdded.UseVisualStyleBackColor = false;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // dgvDeleteSubjects
            // 
            this.dgvDeleteSubjects.AllowUserToAddRows = false;
            this.dgvDeleteSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeleteSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.deleteSubjectName});
            this.dgvDeleteSubjects.Location = new System.Drawing.Point(255, 76);
            this.dgvDeleteSubjects.MultiSelect = false;
            this.dgvDeleteSubjects.Name = "dgvDeleteSubjects";
            this.dgvDeleteSubjects.RowHeadersVisible = false;
            this.dgvDeleteSubjects.Size = new System.Drawing.Size(154, 259);
            this.dgvDeleteSubjects.TabIndex = 15;
            // 
            // dgvAddSubjects
            // 
            this.dgvAddSubjects.AllowUserToAddRows = false;
            this.dgvAddSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.SubjectName});
            this.dgvAddSubjects.Location = new System.Drawing.Point(22, 76);
            this.dgvAddSubjects.MultiSelect = false;
            this.dgvAddSubjects.Name = "dgvAddSubjects";
            this.dgvAddSubjects.RowHeadersVisible = false;
            this.dgvAddSubjects.Size = new System.Drawing.Size(154, 259);
            this.dgvAddSubjects.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.FalseValue = "false";
            this.Add.FillWeight = 50F;
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Add.TrueValue = "true";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subjects";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FalseValue = "false";
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.TrueValue = "false";
            // 
            // deleteSubjectName
            // 
            this.deleteSubjectName.DataPropertyName = "SubjectName";
            this.deleteSubjectName.HeaderText = "Subjects";
            this.deleteSubjectName.Name = "deleteSubjectName";
            this.deleteSubjectName.ReadOnly = true;
            // 
            // cbtnExit
            // 
            this.cbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnExit.FlatAppearance.BorderSize = 0;
            this.cbtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnExit.Image = global::SMS.UI.Properties.Resources.exit;
            this.cbtnExit.Location = new System.Drawing.Point(391, 0);
            this.cbtnExit.Name = "cbtnExit";
            this.cbtnExit.Size = new System.Drawing.Size(33, 33);
            this.cbtnExit.TabIndex = 13;
            this.cbtnExit.UseVisualStyleBackColor = true;
            this.cbtnExit.Click += new System.EventHandler(this.cbtnExit_Click);
            // 
            // AddSubjectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 424);
            this.Controls.Add(this.dgvDeleteSubjects);
            this.Controls.Add(this.dgvAddSubjects);
            this.Controls.Add(this.cbtnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDgvId);
            this.Controls.Add(this.btnAdded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubjectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectFrm";
            this.Load += new System.EventHandler(this.AddSubjectFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularButton cbtnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblDgvId;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.DataGridView dgvDeleteSubjects;
        private System.Windows.Forms.DataGridView dgvAddSubjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteSubjectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
    }
}