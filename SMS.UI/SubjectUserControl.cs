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
    public partial class SubjectUserControl : UserControl
    {
        public SubjectUserControl()
        {
            InitializeComponent();
        }

        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());
        Subjects subject = new Subjects();
        private void SubjectUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            dgvSubject.DataSource = subjectService.GetAll(x => x.IsActive == true);
            dgvSubject.Columns["Id"].Visible = false;
            dgvSubject.Columns["IsActive"].Visible = false;

            int i = 1;
            foreach (DataGridViewRow row in dgvSubject.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dgvSubject.ClearSelection();
            subject = new Subjects();
        }

        private void Clear()
        {
            txtSubjectName.ReadOnly = false;
            txtSubjectName.Text = "";
        }

        private void Close()
        {
            txtSubjectName.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count == 1)
            {
                txtSubjectName.ReadOnly = false;
            }
            else
                MessageBox.Show("Please select a subject !");
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSubject.SelectedRows.Count == 1)
                {
                    subject.Id = (int)dgvSubject.CurrentRow.Cells["Id"].Value;
                    txtSubjectName.Text = dgvSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
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
                    if (subject.Id == 0)
                    {
                        subject.SubjectName = txtSubjectName.Text.Trim();
                        subjectService.Add(subject);
                    }
                    else
                    {
                        var getSubject = subjectService.Get(subject.Id);
                        getSubject.SubjectName = txtSubjectName.Text.Trim();
                        subjectService.UpdateOrDelete(getSubject);
                    }
                    List();
                    Clear();
                    Close();
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
            result = MessageBox.Show("Do you want to delete the subject ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvSubject.SelectedRows.Count == 1)
                    {
                        var getSubject = subjectService.Get(subject.Id);
                        getSubject.Id = (int)dgvSubject.CurrentRow.Cells["Id"].Value;
                        getSubject.IsActive = false;
                        subjectService.UpdateOrDelete(getSubject);
                        List();
                        Clear();
                        dgvSubject.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !", ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSubject.DataSource = subjectService.GetAll(x => x.SubjectName.Contains(txtSearch.Text));

            dgvSubject.Columns["Id"].Visible = false;
            dgvSubject.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvSubject.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void dgvSubject_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvSubject.Rows.Count > 0)
                dgvSubject.Rows[0].Selected = false;
        }
    }
}
