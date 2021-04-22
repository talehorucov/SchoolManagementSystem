using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.UI
{
    public partial class DashboardFrm : Form
    {
        public DashboardFrm()
        {
            InitializeComponent();
        }

        Logging logging = new Logging();
        EFStudentsMessageDAL eFStudentsMessageDAL = new EFStudentsMessageDAL();

        ILoggingService loggingService = new LoggingManager(new EFLoggingDAL());
        private void DashboardFrm_Load(object sender, EventArgs e)
        {
            lblSMS.Left += 659;
            cbtnExitApp.Left += 524;
            cbtnMinimize.Left += 528;
            cbtnInfo.Left += 533;
            cbtnMessage.Left += 541;
            cbtnNotification.Left += 548;
            cbtnBack.Visible = false;
            lblPage.Location = new Point(72, 5);
            btnStudent.Visible = false;
            btnStaff.Visible = false;
            btnSubject.Visible = false;
            btnClass.Visible = false;
            btnRoles.Visible = false;
            btnExamType.Visible = false;
            cbtnMessage.Visible = false;
            cbtnNotification.Visible = false;

            PanelControls(); 

            if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId != 1)
            {
                cbtnMessage.Visible = true;

                btnAttendance.Top -= 224;
                btnExamResult.Top -= 336;
                cbtnNotification.Left += 33;
                lblSMS.Left += 33;
            }
            else if (StaffManager.onlineStaff == null)
            {
                cbtnNotification.Visible = true;
                cbtnNotification.Left += 33;
                lblSMS.Left += 30;

                btnAttendance.Top -= 224;
                btnExamResult.Top -= 336;
            }
            else if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId == 1)
            {
                btnStudent.Visible = true;
                btnStaff.Visible = true;
                btnSubject.Visible = true;
                btnClass.Visible = true;
                btnRoles.Visible = true;
                btnExamType.Visible = true;
                cbtnMessage.Visible = true;
                lblSMS.Left += 33;
            }
        }
        #region FormButtons
        private void BtnBack()
        {
            cbtnBack.Visible = true;
            lblPage.Location = new Point(72, 5);
        }

        private void cbtnExitApp_Click(object sender, EventArgs e)
        {
            if (StudentsManager.onlineStudent == null)
            {
                logging.StaffId = StaffManager.onlineStaff.StaffId;
                logging.StudentId = null;
                logging.Message = "Staff Succesfully Logged Out";
                logging.LogDate = DateTime.Now;
                loggingService.Add(logging);
            }
            else if (StaffManager.onlineStaff == null)
            {
                logging.StudentId = StudentsManager.onlineStudent.Id;
                logging.StaffId = null;
                logging.Message = "Student Succesfully Logged Out";
                logging.LogDate = DateTime.Now;
                loggingService.Add(logging);
            }
            Application.Exit();
        }
        private void cbtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbtnInfo_Click(object sender, EventArgs e)
        {
            InformationFrm frm = new InformationFrm();
            frm.ShowDialog();
        }
        private void cbtnMessage_Click(object sender, EventArgs e)
        {
            MessageFrm messageFrm = new MessageFrm();
            messageFrm.ShowDialog();
        }

        private void cbtnNotification_Click(object sender, EventArgs e)
        {
            cbtnNotification.Image = (Image)(new Bitmap(SMS.UI.Properties.Resources.notification0, new Size(36, 36)));
            NotificationFrm notificationFrm = new NotificationFrm();
            notificationFrm.ShowDialog();
        }

        private void PanelControls()
        {
            pnlMiddle.Controls.Clear();
            if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.RoleId != 1)
                pnlMiddle.Controls.Add(new StaffDashboardUserControl());
            else if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.RoleId == 1)
                pnlMiddle.Controls.Add(new AdminDashboardUserControl());
            else
            {
                pnlMiddle.Controls.Add(new StudentDashboardUserControl());
                var message = eFStudentsMessageDAL.GetMessages(StudentsManager.onlineStudent.Id);
                int messageCount = message.Count();
                if (messageCount == 0)
                    cbtnNotification.Image = (Image)(new Bitmap(Properties.Resources.notification0, new Size(36, 36)));
                else
                    cbtnNotification.Image = (Image)(new Bitmap(Properties.Resources.notification1, new Size(36, 36)));
            }
        }
        private void cbtnBack_Click(object sender, EventArgs e)
        {
            PanelControls();
            pnlLeft.Hide();
            lblPage.Text = "Dashboard";
            pnlLeft.Show();
            cbtnBack.Visible = false;
        }
        #endregion
        #region UserControlButtons
        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelControls();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new StudentUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Students";
            BtnBack();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new StaffUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Staffs";
            BtnBack();
        }
        private void btnSubject_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new SubjectUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Subjects";
            BtnBack();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new ClassUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Classes";
            BtnBack();
        }


        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new AttendanceUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Attendance";
            BtnBack();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new RoleUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Roles";
            BtnBack();
        }

        private void btnExamType_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new ExamTypeUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Exam Type";
            BtnBack();
        }

        private void btnExamResult_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new ExamUserControl());
            pnlLeft.Hide();
            lblPage.Text = "Exam Result";
            BtnBack();
        }
        #endregion
        #region BtnHover
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            this.btnHome.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnHome.Image = (Image)(new Bitmap(Properties.Resources.home, new Size(36, 36)));
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            this.btnHome.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnHome.Image = (Image)(new Bitmap(Properties.Resources.home, new Size(32, 32)));
        }

        private void btnStudent_MouseEnter(object sender, EventArgs e)
        {
            this.btnStudent.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnStudent.Image = (Image)(new Bitmap(Properties.Resources.student, new Size(36, 36)));
        }

        private void btnStudent_MouseLeave(object sender, EventArgs e)
        {
            this.btnStudent.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnStudent.Image = (Image)(new Bitmap(Properties.Resources.student, new Size(32, 32)));
        }

        private void btnStaff_MouseEnter(object sender, EventArgs e)
        {
            this.btnStaff.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnStaff.Image = (Image)(new Bitmap(Properties.Resources.staff, new Size(36, 36)));
        }

        private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
            this.btnStaff.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnStaff.Image = (Image)(new Bitmap(Properties.Resources.staff, new Size(32, 32)));
        }

        private void btnSubject_MouseEnter(object sender, EventArgs e)
        {
            this.btnSubject.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnSubject.Image = (Image)(new Bitmap(Properties.Resources.subject, new Size(36, 36)));
        }

        private void btnSubject_MouseLeave(object sender, EventArgs e)
        {
            this.btnSubject.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnSubject.Image = (Image)(new Bitmap(Properties.Resources.subject, new Size(32, 32)));
        }

        private void btnClass_MouseEnter(object sender, EventArgs e)
        {
            this.btnClass.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnClass.Image = (Image)(new Bitmap(Properties.Resources._class, new Size(36, 36)));
        }

        private void btnClass_MouseLeave(object sender, EventArgs e)
        {
            this.btnClass.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnClass.Image = (Image)(new Bitmap(Properties.Resources._class, new Size(32, 32)));
        }

        private void btnAttendance_MouseEnter(object sender, EventArgs e)
        {
            this.btnAttendance.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnAttendance.Image = (Image)(new Bitmap(Properties.Resources.attendance, new Size(36, 36)));
        }

        private void btnAttendance_MouseLeave(object sender, EventArgs e)
        {
            this.btnAttendance.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnAttendance.Image = (Image)(new Bitmap(Properties.Resources.attendance, new Size(32, 32)));
        }

        private void btnRoles_MouseEnter(object sender, EventArgs e)
        {
            this.btnRoles.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnRoles.Image = (Image)(new Bitmap(Properties.Resources.role, new Size(36, 36)));
        }

        private void btnRoles_MouseLeave(object sender, EventArgs e)
        {
            this.btnRoles.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnRoles.Image = (Image)(new Bitmap(Properties.Resources.role, new Size(32, 32)));
        }

        private void btnResult_MouseEnter(object sender, EventArgs e)
        {
            this.btnExamResult.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnExamResult.Image = (Image)(new Bitmap(Properties.Resources.result, new Size(36, 36)));
        }

        private void btnResult_MouseLeave(object sender, EventArgs e)
        {
            this.btnExamResult.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnExamResult.Image = (Image)(new Bitmap(Properties.Resources.result, new Size(32, 32)));
        }

        private void btnExamType_MouseEnter(object sender, EventArgs e)
        {
            this.btnExamType.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.btnExamType.Image = (Image)(new Bitmap(Properties.Resources.examType, new Size(36, 36)));
        }

        private void btnExamType_MouseLeave(object sender, EventArgs e)
        {
            this.btnExamType.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            this.btnExamType.Image = (Image)(new Bitmap(Properties.Resources.examType, new Size(32, 32)));
        }
        #endregion
    }
}
