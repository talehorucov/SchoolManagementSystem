using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.DAL.Concrete.EntityFramework;
using SMS.BLL.Concrete;
using SMS.BLL.Abstracts;
using SMS.Entities.Entity;

namespace SMS.UI
{
    public partial class StudentDashboardUserControl : UserControl
    {
        public StudentDashboardUserControl()
        {
            InitializeComponent();
        }

        EFStudentsDAL studentsDAL = new EFStudentsDAL();
        IGenericService<Students> studentService = new StudentsManager(new EFStudentsDAL());
        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());

        private void StudentDashboardUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            int studentId = StudentsManager.onlineStudent.Id;
            
            dgvDashboard.AutoGenerateColumns = false;
            var students = studentsDAL.StudentDashboardsList(studentId);
            dgvDashboard.DataSource = students;
            lblFirstname.Text = StudentsManager.onlineStudent.FullName;
            lblBornDate.Text = StudentsManager.onlineStudent.BornDate.ToString("dd/MM/yyyy");
            lblClass.Text = classService.GetAll(x => x.Id == StudentsManager.onlineStudent.ClassId).Select(x => x.ClassName).FirstOrDefault();
            lblContactNo.Text = StudentsManager.onlineStudent.ContactNo;
            lblAddress.Text = StudentsManager.onlineStudent.Address;
        }
        
    }
}
