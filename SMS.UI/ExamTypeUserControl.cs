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

namespace SMS.UI
{
    public partial class ExamTypeUserControl : UserControl
    {
        public ExamTypeUserControl()
        {
            InitializeComponent();
        }

        IGenericService<ExamTypes> examTypeService = new ExamTypesManager(new EFExamTypesDAL());
        ExamTypes examType = new ExamTypes();

        private void ExamTypeUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            dgvExamType.DataSource = examTypeService.GetAll(x => x.IsActive == true);
            dgvExamType.Columns["Id"].Visible = false;
            dgvExamType.Columns["IsActive"].Visible = false;

            int i = 1;
            foreach (DataGridViewRow row in dgvExamType.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dgvExamType.ClearSelection();
            examType = new ExamTypes();
        }
        private void Clear()
        {
            txtExamType.Text = "";
            txtExamType.ReadOnly = false;
        }
        private void Open()
        {
            txtExamType.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExamType.SelectedRows.Count == 1)
            {
                txtExamType.ReadOnly = false;
            }
            else
                MessageBox.Show("Please select a Exam Type !");
        }

        private void dgvExamType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvExamType.SelectedRows.Count == 1)
                {
                    examType.Id = (int)dgvExamType.CurrentRow.Cells["Id"].Value;
                    txtExamType.Text = dgvExamType.CurrentRow.Cells["Type"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    if (examType.Id == 0)
                    {
                        examType.Type = txtExamType.Text.Trim();
                        examTypeService.Add(examType);
                    }
                    else
                    {
                        var getExamType = examTypeService.Get(examType.Id);
                        getExamType.Type = txtExamType.Text.Trim();
                        examTypeService.UpdateOrDelete(getExamType);
                    }
                    List();
                    Clear();
                    Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !", ex.Message);
                }
            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete the Exam Type ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvExamType.SelectedRows.Count == 1)
                    {
                        var getExamType = examTypeService.Get(examType.Id);
                        getExamType.Id = (int)dgvExamType.CurrentRow.Cells["Id"].Value;
                        getExamType.IsActive = false;
                        examTypeService.UpdateOrDelete(getExamType);
                        List();
                        Clear();
                        dgvExamType.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
        }

        private void dgvExamType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvExamType.Rows.Count > 0)
                dgvExamType.Rows[0].Selected = false;
        }
    }
}
