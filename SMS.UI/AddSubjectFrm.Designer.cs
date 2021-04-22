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
            this.clbDelete = new System.Windows.Forms.CheckedListBox();
            this.clbAdd = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDgvId = new System.Windows.Forms.Label();
            this.btnAdded = new System.Windows.Forms.Button();
            this.cbtnExit = new SMS.UI.CircularButton();
            this.SuspendLayout();
            // 
            // clbDelete
            // 
            this.clbDelete.FormattingEnabled = true;
            this.clbDelete.Location = new System.Drawing.Point(255, 67);
            this.clbDelete.Name = "clbDelete";
            this.clbDelete.Size = new System.Drawing.Size(154, 259);
            this.clbDelete.TabIndex = 3;
            // 
            // clbAdd
            // 
            this.clbAdd.FormattingEnabled = true;
            this.clbAdd.Location = new System.Drawing.Point(22, 67);
            this.clbAdd.Name = "clbAdd";
            this.clbAdd.Size = new System.Drawing.Size(154, 259);
            this.clbAdd.TabIndex = 2;
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
            // cbtnExit
            // 
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
            this.Controls.Add(this.cbtnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDgvId);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.clbDelete);
            this.Controls.Add(this.clbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubjectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectFrm";
            this.Load += new System.EventHandler(this.AddSubjectFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDelete;
        private System.Windows.Forms.CheckedListBox clbAdd;
        private CircularButton cbtnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblDgvId;
        private System.Windows.Forms.Button btnAdded;
    }
}