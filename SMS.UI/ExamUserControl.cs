using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.Entities.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SMS.UI
{
    public partial class ExamUserControl : UserControl
    {
        public ExamUserControl()
        {
            InitializeComponent();
        }

        IGenericService<ExamTypes> examTypesService = new ExamTypesManager(new EFExamTypesDAL());
        IGenericService<ExamResult> examResultsService = new ExamResultManager(new EFExamResultsDAL());
        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        EFExamResultsDAL examResultsDAL = new EFExamResultsDAL();
        ExamResult examResult = new ExamResult();

        private void ExamUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                cmbExam.DataSource = examTypesService.GetAll();
                cmbExam.DisplayMember = "Type";
                cmbExam.ValueMember = "Id";

                if (StudentsManager.onlineStudent == null)
                {
                    cmbClass.DataSource = classService.GetAll(x => x.Staffs.Any(a => a.Id == StaffManager.onlineStaff.StaffId));
                    cmbClass.DisplayMember = "ClassName";
                    cmbClass.ValueMember = "Id";
                }
                else
                {
                    cmbClass.Visible = false;
                    lblClass.Visible = false;
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
                int classId = Convert.ToInt32(cmbClass.SelectedValue);
                int examTypeId = Convert.ToInt32(cmbExam.SelectedValue);
                if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId != 1)
                {
                    var a = examResultsDAL.GetUnCheckedExam(classId, examTypeId, StaffManager.onlineStaff.StaffId);
                    if (a.Count == 0)
                    {
                        dgvExam.DataSource = examResultsDAL.GetCheckedExam(classId, StaffManager.onlineStaff.StaffId);
                    }
                    else
                        dgvExam.DataSource = a;
                }
                else if (StudentsManager.onlineStudent == null && StaffManager.onlineStaff.StaffId == 1)
                {
                    dgvExam.DataSource = examResultsDAL.GetExamForAdmin(examTypeId, classId);
                    btnSave.Visible = false;
                }
                else if (StaffManager.onlineStaff == null)
                {
                    dgvExam.DataSource = examResultsDAL.GetExam(examTypeId, StudentsManager.onlineStudent.Id);
                    btnSave.Visible = false;
                }
                dgvExam.Columns["StudentId"].Visible = false;
                dgvExam.Columns["ExamResultId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvExam[column, row];
            DataGridViewCell cell2 = dgvExam[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgvExam_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                if (e.RowIndex < 1 || e.ColumnIndex < 0)
                    return;
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = dgvExam.AdvancedCellBorderStyle.Top;
                }
            }
        }

        private void dgvExam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void dgvExam_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvExam.Rows.Count > 0)
                dgvExam.Rows[0].Selected = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int classId = Convert.ToInt32(cmbClass.SelectedValue);
                int examTypeId = Convert.ToInt32(cmbExam.SelectedValue);
                var CheckedExam = examResultsDAL.GetUnCheckedExam(classId, examTypeId, StaffManager.onlineStaff.StaffId);
                if (CheckedExam.Count == 0)
                {
                    for (int i = 0; i < dgvExam.Rows.Count; i++)
                    {
                        examResult.ExamTypesId = Convert.ToInt32(cmbClass.SelectedValue);
                        examResult.StudentId = Convert.ToInt32(dgvExam.Rows[i].Cells["StudentId"].Value);
                        examResult.SubjectId = StaffManager.onlineStaff.SubjectId;
                        examResult.Mark = Convert.ToByte(dgvExam.Rows[i].Cells["Mark"].Value);
                        examResultsDAL.Add(examResult);
                    }
                }
                else
                {
                    for (int i = 0; i < dgvExam.Rows.Count; i++)
                    {
                        int examResultId = Convert.ToInt32(dgvExam.Rows[i].Cells["ExamResultId"].Value);
                        var getExamResult = examResultsService.Get(examResultId);
                        getExamResult.ExamTypesId = Convert.ToInt32(cmbClass.SelectedValue);
                        getExamResult.StudentId = Convert.ToInt32(dgvExam.Rows[i].Cells["StudentId"].Value);
                        getExamResult.SubjectId = StaffManager.onlineStaff.SubjectId;
                        getExamResult.Mark = Convert.ToByte(dgvExam.Rows[i].Cells["Mark"].Value);
                        examResultsDAL.UpdateOrDelete(getExamResult);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            
        }
    }
}
