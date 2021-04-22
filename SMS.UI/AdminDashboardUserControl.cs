using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Entities.Entity;
using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.DAL.Context;
using SMS.Entities.ComplexTypes;

namespace SMS.UI
{
    public partial class AdminDashboardUserControl : UserControl
    {
        public AdminDashboardUserControl()
        {
            InitializeComponent();
        }

        EFLoggingDAL loggingDAL = new EFLoggingDAL();
        EFClassesDAL classesDAL = new EFClassesDAL();
        IGenericService<Students> studentService = new StudentsManager(new EFStudentsDAL());
        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        IGenericService<Staffs> staffService = new StaffManager(new EFStaffsDAL());

        private void AdminDashboardUserControl_Load(object sender, EventArgs e)
        {
            lblStudent.Text = studentService.GetAll(x => x.IsActive == true).Count().ToString();
            lblClass.Text = classService.GetAll(x => x.IsActive == true).Count().ToString();
            lblTeacher.Text = staffService.GetAll(x => x.IsActive == true).Count().ToString();

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            for (int i = 1; i < 12; i++)
            {
                var a = classesDAL.GetStudentsCount(i.ToString());
                chart1.Series["Student"].Points.AddXY(i, a.Count);
            };
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0)
            {
                dgvLog.DataSource = loggingDAL.GetStudents();
                dgvLog.Columns["TeacherName"].Visible = false;
                dgvLog.Columns["StudentName"].Visible = true;
            }
            else
            {
                dgvLog.DataSource = loggingDAL.GetTeachers();
                dgvLog.Columns["StudentName"].Visible = false;
                dgvLog.Columns["TeacherName"].Visible = true;
            }
            dgvLog.Columns["Id"].Visible = false;

            int i = 1;
            foreach (DataGridViewRow row in dgvLog.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }
    }
}
