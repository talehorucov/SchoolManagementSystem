namespace SMS.UI
{
    partial class DashboardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFrm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cbtnExitApp = new SMS.UI.CircularButton();
            this.cbtnBack = new SMS.UI.CircularButton();
            this.lblSMS = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.cbtnNotification = new SMS.UI.CircularButton();
            this.cbtnMessage = new SMS.UI.CircularButton();
            this.cbtnInfo = new SMS.UI.CircularButton();
            this.cbtnMinimize = new SMS.UI.CircularButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExamType = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnExamResult = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightGray;
            this.pnlTop.Controls.Add(this.cbtnExitApp);
            this.pnlTop.Controls.Add(this.cbtnBack);
            this.pnlTop.Controls.Add(this.lblSMS);
            this.pnlTop.Controls.Add(this.lblPage);
            this.pnlTop.Controls.Add(this.cbtnNotification);
            this.pnlTop.Controls.Add(this.cbtnMessage);
            this.pnlTop.Controls.Add(this.cbtnInfo);
            this.pnlTop.Controls.Add(this.cbtnMinimize);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // cbtnExitApp
            // 
            this.cbtnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnExitApp.FlatAppearance.BorderSize = 0;
            this.cbtnExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cbtnExitApp, "cbtnExitApp");
            this.cbtnExitApp.Image = global::SMS.UI.Properties.Resources.exit;
            this.cbtnExitApp.Name = "cbtnExitApp";
            this.cbtnExitApp.UseVisualStyleBackColor = true;
            this.cbtnExitApp.Click += new System.EventHandler(this.cbtnExitApp_Click);
            // 
            // cbtnBack
            // 
            this.cbtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnBack.FlatAppearance.BorderSize = 0;
            this.cbtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cbtnBack, "cbtnBack");
            this.cbtnBack.Name = "cbtnBack";
            this.cbtnBack.UseVisualStyleBackColor = true;
            this.cbtnBack.Click += new System.EventHandler(this.cbtnBack_Click);
            // 
            // lblSMS
            // 
            resources.ApplyResources(this.lblSMS, "lblSMS");
            this.lblSMS.BackColor = System.Drawing.Color.Transparent;
            this.lblSMS.ForeColor = System.Drawing.Color.Black;
            this.lblSMS.Name = "lblSMS";
            // 
            // lblPage
            // 
            resources.ApplyResources(this.lblPage, "lblPage");
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.ForeColor = System.Drawing.Color.Black;
            this.lblPage.Name = "lblPage";
            // 
            // cbtnNotification
            // 
            this.cbtnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnNotification.FlatAppearance.BorderSize = 0;
            this.cbtnNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cbtnNotification, "cbtnNotification");
            this.cbtnNotification.Image = global::SMS.UI.Properties.Resources.notification0;
            this.cbtnNotification.Name = "cbtnNotification";
            this.cbtnNotification.TabStop = false;
            this.cbtnNotification.UseVisualStyleBackColor = true;
            this.cbtnNotification.Click += new System.EventHandler(this.cbtnNotification_Click);
            // 
            // cbtnMessage
            // 
            this.cbtnMessage.BackgroundImage = global::SMS.UI.Properties.Resources.message;
            resources.ApplyResources(this.cbtnMessage, "cbtnMessage");
            this.cbtnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnMessage.FlatAppearance.BorderSize = 0;
            this.cbtnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cbtnMessage.Name = "cbtnMessage";
            this.cbtnMessage.TabStop = false;
            this.cbtnMessage.UseVisualStyleBackColor = true;
            this.cbtnMessage.Click += new System.EventHandler(this.cbtnMessage_Click);
            // 
            // cbtnInfo
            // 
            this.cbtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnInfo.FlatAppearance.BorderSize = 0;
            this.cbtnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cbtnInfo, "cbtnInfo");
            this.cbtnInfo.Image = global::SMS.UI.Properties.Resources.info;
            this.cbtnInfo.Name = "cbtnInfo";
            this.cbtnInfo.TabStop = false;
            this.cbtnInfo.UseVisualStyleBackColor = true;
            this.cbtnInfo.Click += new System.EventHandler(this.cbtnInfo_Click);
            // 
            // cbtnMinimize
            // 
            this.cbtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnMinimize.FlatAppearance.BorderSize = 0;
            this.cbtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cbtnMinimize, "cbtnMinimize");
            this.cbtnMinimize.Image = global::SMS.UI.Properties.Resources.minimize;
            this.cbtnMinimize.Name = "cbtnMinimize";
            this.cbtnMinimize.TabStop = false;
            this.cbtnMinimize.UseVisualStyleBackColor = true;
            this.cbtnMinimize.Click += new System.EventHandler(this.cbtnMinimize_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.pnlLeft.Controls.Add(this.btnExamType);
            this.pnlLeft.Controls.Add(this.btnSubject);
            this.pnlLeft.Controls.Add(this.btnStaff);
            this.pnlLeft.Controls.Add(this.btnExamResult);
            this.pnlLeft.Controls.Add(this.btnRoles);
            this.pnlLeft.Controls.Add(this.btnAttendance);
            this.pnlLeft.Controls.Add(this.btnClass);
            this.pnlLeft.Controls.Add(this.btnStudent);
            this.pnlLeft.Controls.Add(this.btnHome);
            resources.ApplyResources(this.pnlLeft, "pnlLeft");
            this.pnlLeft.Name = "pnlLeft";
            // 
            // btnExamType
            // 
            this.btnExamType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExamType.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExamType, "btnExamType");
            this.btnExamType.ForeColor = System.Drawing.Color.White;
            this.btnExamType.Image = global::SMS.UI.Properties.Resources.examType;
            this.btnExamType.Name = "btnExamType";
            this.btnExamType.UseVisualStyleBackColor = true;
            this.btnExamType.Click += new System.EventHandler(this.btnExamType_Click);
            this.btnExamType.MouseEnter += new System.EventHandler(this.btnExamType_MouseEnter);
            this.btnExamType.MouseLeave += new System.EventHandler(this.btnExamType_MouseLeave);
            // 
            // btnSubject
            // 
            this.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSubject, "btnSubject");
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.Image = global::SMS.UI.Properties.Resources.subject;
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            this.btnSubject.MouseEnter += new System.EventHandler(this.btnSubject_MouseEnter);
            this.btnSubject.MouseLeave += new System.EventHandler(this.btnSubject_MouseLeave);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::SMS.UI.Properties.Resources.staff;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            this.btnStaff.MouseEnter += new System.EventHandler(this.btnStaff_MouseEnter);
            this.btnStaff.MouseLeave += new System.EventHandler(this.btnStaff_MouseLeave);
            // 
            // btnExamResult
            // 
            this.btnExamResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExamResult.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExamResult, "btnExamResult");
            this.btnExamResult.ForeColor = System.Drawing.Color.White;
            this.btnExamResult.Image = global::SMS.UI.Properties.Resources.result;
            this.btnExamResult.Name = "btnExamResult";
            this.btnExamResult.UseVisualStyleBackColor = true;
            this.btnExamResult.Click += new System.EventHandler(this.btnExamResult_Click);
            this.btnExamResult.MouseEnter += new System.EventHandler(this.btnResult_MouseEnter);
            this.btnExamResult.MouseLeave += new System.EventHandler(this.btnResult_MouseLeave);
            // 
            // btnRoles
            // 
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRoles, "btnRoles");
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = global::SMS.UI.Properties.Resources.role;
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            this.btnRoles.MouseEnter += new System.EventHandler(this.btnRoles_MouseEnter);
            this.btnRoles.MouseLeave += new System.EventHandler(this.btnRoles_MouseLeave);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAttendance, "btnAttendance");
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = global::SMS.UI.Properties.Resources.attendance;
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            this.btnAttendance.MouseEnter += new System.EventHandler(this.btnAttendance_MouseEnter);
            this.btnAttendance.MouseLeave += new System.EventHandler(this.btnAttendance_MouseLeave);
            // 
            // btnClass
            // 
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClass, "btnClass");
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = global::SMS.UI.Properties.Resources._class;
            this.btnClass.Name = "btnClass";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            this.btnClass.MouseEnter += new System.EventHandler(this.btnClass_MouseEnter);
            this.btnClass.MouseLeave += new System.EventHandler(this.btnClass_MouseLeave);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStudent, "btnStudent");
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::SMS.UI.Properties.Resources.student;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseEnter += new System.EventHandler(this.btnStudent_MouseEnter);
            this.btnStudent.MouseLeave += new System.EventHandler(this.btnStudent_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SMS.UI.Properties.Resources.home;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // pnlMiddle
            // 
            resources.ApplyResources(this.pnlMiddle, "pnlMiddle");
            this.pnlMiddle.Name = "pnlMiddle";
            // 
            // DashboardFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardFrm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private CircularButton cbtnNotification;
        private CircularButton cbtnMessage;
        private CircularButton cbtnInfo;
        private CircularButton cbtnMinimize;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnExamResult;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Button btnStaff;
        private CircularButton cbtnBack;
        private System.Windows.Forms.Button btnExamType;
        private CircularButton cbtnExitApp;
    }
}