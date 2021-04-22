using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL.Abstracts;
using SMS.Entities.Entity;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.DAL.Context;
using System.Data.Entity;
using SMS.Entities.ComplexTypes;

namespace SMS.UI
{
    public partial class AttendanceUserControl : UserControl
    {
        public AttendanceUserControl()
        {
            InitializeComponent();
        }

        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());
        IGenericService<Attendances> attendanceService = new AttendancesManager(new EFAttendanceDAL());
        EFAttendanceDAL attendanceDAL = new EFAttendanceDAL();
        Attendances attendance = new Attendances();

        private void AttendanceUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId == 1)
                {
                    cmbClass.DisplayMember = "ClassName";
                    cmbClass.ValueMember = "Id";
                    cmbClass.DataSource = classService.GetAll(x => x.IsActive == true && x.Staffs.Any(a => a.Id == StaffManager.onlineStaff.StaffId));


                    int stfu = Convert.ToInt32(cmbClass.SelectedValue);
                    cmbSubject.DisplayMember = "SubjectName";
                    cmbSubject.ValueMember = "Id";
                    cmbSubject.DataSource = subjectService.GetAll(x => x.IsActive == true && x.Classes.Any(a => a.Id == stfu));


                    cmbSubject.Enabled = false;
                    btnSave.Visible = false;
                }
                else if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId != 1)
                {
                    cmbClass.DataSource = classService.GetAll(x => x.IsActive == true && x.Staffs.Any(a => a.Id == StaffManager.onlineStaff.StaffId));
                    cmbClass.DisplayMember = "ClassName";
                    cmbClass.ValueMember = "Id";

                    cmbSubject.Visible = false;
                    lblSubject.Visible = false;
                    btnLoad.Top -= 39;
                    btnSave.Top -= 39;

                    dtpDate.MinDate = DateTime.Today.AddDays(-7);
                    dtpDate.MaxDate = DateTime.Today;
                }
                else if (StaffManager.onlineStaff == null)
                {
                    cmbSubject.Visible = false;
                    btnLoad.Top -= 78;

                    lblSubject.Visible = false;
                    lblClass.Visible = false;
                    lblDate.Visible = false;

                    cmbClass.Visible = false;
                    btnSave.Visible = false;
                    dtpDate.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId == 1)
                {
                    if (cmbSubject.Enabled)
                    {
                        DateTime date = dtpDate.Value;
                        int classId = Convert.ToInt32(cmbClass.SelectedValue);
                        int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);

                        var attendance = attendanceDAL.GetAttendanceForAdmin(subjectId, date, classId);
                        if (attendance.Count == 0)
                        {
                            dgvAttendance.DataSource = null;
                            MessageBox.Show("This class was not checked by the teacher");
                        }
                        else
                        {
                            dgvAttendance.DataSource = attendance;
                            dgvAttendance.Columns["Id"].Visible = false;
                            dgvAttendance.Columns["SubjectName"].Visible = false;
                            dgvAttendance.Columns["AttendDate"].Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Please select a subject !");
                }
                else if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId != 1)
                {
                    DateTime date = dtpDate.Value;
                    int classId = Convert.ToInt32(cmbClass.SelectedValue);

                    var attendance = attendanceDAL.GetAttendanceForTeacher(date, classId);

                    if (attendance.Count == 0)
                    {
                        var newAttendance = attendanceDAL.GetAttendanceForTeacher(classId);
                        dgvAttendance.DataSource = newAttendance;
                    }
                    else
                        dgvAttendance.DataSource = attendance;

                    dgvAttendance.Columns["Id"].Visible = false;
                    dgvAttendance.Columns["SubjectName"].Visible = false;
                    dgvAttendance.Columns["AttendDate"].Visible = false;
                }
                else if (StaffManager.onlineStaff == null)
                {
                    var studentAttendance = attendanceDAL.GetAttendanceForStudent(StudentsManager.onlineStudent.Id);
                    dgvAttendance.DataSource = studentAttendance;

                    dgvAttendance.Columns["Id"].Visible = false;
                    dgvAttendance.Columns["Student"].Visible = false;
                }
                int i = 1;
                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {
                    row.Cells["Row"].Value = i;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save the changes?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < dgvAttendance.Rows.Count; i++)
                    {
                        if (dgvAttendance.Rows[i].Cells["IsAttend"].Value == null)
                        {
                            dgvAttendance.Rows[i].Cells["IsAttend"].Value = false;
                        }
                        attendance.AttendanceDate = dtpDate.Value;
                        attendance.StudentId = (int)dgvAttendance.Rows[i].Cells["Id"].Value;
                        attendance.IsAttend = Convert.ToBoolean(dgvAttendance.Rows[i].Cells["IsAttend"].Value.ToString());
                        attendance.SubjectId = StaffManager.onlineStaff.SubjectId;
                        attendanceService.Add(attendance);
                    }
                    dgvAttendance.DataSource = null;
                    MessageBox.Show("You checked the class !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ! " + ex.Message);
                }
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbClass.SelectedValue.ToString() != null && StaffManager.onlineStaff.StaffId == 1)
                {
                    cmbSubject.Enabled = true;

                    int classId = Convert.ToInt32(cmbClass.SelectedValue);
                    cmbSubject.DataSource = subjectService.GetAll(x => x.IsActive == true && x.Classes.Any(a => a.Id == classId));
                    cmbSubject.DisplayMember = "SubjectName";
                    cmbSubject.ValueMember = "Id";
                    cmbSubject.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
