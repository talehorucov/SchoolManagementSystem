using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.Entities.ComplexTypes;
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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        Staffs staffs = new Staffs();
        Students students = new Students();
        Logging logging = new Logging();

        IStaffService staffService = new StaffManager(new EFStaffsDAL());
        IStudentsService studentService = new StudentsManager(new EFStudentsDAL());
        ILoggingService loggingService = new LoggingManager(new EFLoggingDAL());

        int mouseX, mouseY;
        bool mouseMove;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove)
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblLoginId.Text == "0")
            {
                students.Username = txtUsername.Text.Trim();
                students.Password = txtPassword.Text.Trim();
                StudentsManager.onlineStudent = studentService.StudentLogin(students.Username, students.Password);
                if (StudentsManager.onlineStudent.Id != 0)
                {
                    logging.StudentId = StudentsManager.onlineStudent.Id;
                    logging.StaffId = null;
                    logging.Message = "Student Succesfully Logged In";
                    loggingService.Add(logging);
                    DashboardFrm frm = new DashboardFrm();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Username or password is incorrect !");
            }
            else if (lblLoginId.Text == "1")
            {
                staffs.Username = txtUsername.Text.Trim();
                staffs.Password = txtPassword.Text.Trim();
                StaffManager.onlineStaff = staffService.StaffLogin(staffs.Username, staffs.Password);
                if (StaffManager.onlineStaff.StaffId != 0)
                {
                    logging.StaffId = StaffManager.onlineStaff.StaffId;
                    logging.StudentId = null;
                    logging.Message = "Staff Succesfully Logged In";
                    loggingService.Add(logging);
                    DashboardFrm frm = new DashboardFrm();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Username or password is incorrect !");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username cannot be empty !");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Password cannot be empty !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
