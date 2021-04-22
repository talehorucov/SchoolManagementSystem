using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.BLL.Abstracts;
using SMS.Entities.Entity;

namespace SMS.UI
{
    public partial class StaffDashboardUserControl : UserControl
    {
        public StaffDashboardUserControl()
        {
            InitializeComponent();
        }

        EFStaffsDAL staffDAL = new EFStaffsDAL();
        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());
        private void StaffDashboardUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dgvDashboard.AutoGenerateColumns = false;

            cmbClasses.DataSource = classService.GetAll(x => x.IsActive == true && x.Staffs.Any(a => a.Id == StaffManager.onlineStaff.StaffId));
            cmbClasses.DisplayMember = "ClassName";
            cmbClasses.ValueMember = "Id";

            lblFirstname.Text = StaffManager.onlineStaff.Firstname + " " + StaffManager.onlineStaff.Lastname;
            lblBornDate.Text = StaffManager.onlineStaff.BornDate.ToString("dd/MM/yyyy");
            lblSubject.Text = subjectService.GetAll(x=>x.Staffs.Any(a=>a.Id == StaffManager.onlineStaff.StaffId)).Select(b=>b.SubjectName).FirstOrDefault();
            lblContactNo.Text = StaffManager.onlineStaff.ContactNo;
            lblAddress.Text = StaffManager.onlineStaff.Address;
            cmbClasses.SelectedIndex = -1;
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDashboard.DataSource = staffDAL.StaffDashboardList(cmbClasses.Text);
            int i = 1;
            foreach (DataGridViewRow row in dgvDashboard.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }
    }
}
