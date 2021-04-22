using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.DAL.Context;
using SMS.BLL.Abstracts;
using SMS.Entities.Entity;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;

namespace SMS.UI
{
    public partial class ClassUserControl : UserControl
    {
        public ClassUserControl()
        {
            InitializeComponent();
        }

        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        Classes classes = new Classes();
        AddSubjectFrm frm = new AddSubjectFrm();

        private void ClassUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dgvClass.ClearSelection();
            classes = new Classes();
        }

        private void Clear()
        {
            txtClassName.Text = "";
            txtClassName.ReadOnly = false;
        }
        private void Close()
        {
            txtClassName.ReadOnly = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 1)
            {
                txtClassName.ReadOnly = false;
            }
            else
                MessageBox.Show("Please select a class !");
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClass.SelectedRows.Count == 1)
                {
                    using (SMSContext context = new SMSContext())
                    {
                        classes.Id = Convert.ToInt32((dgvClass.CurrentRow.Cells["Id"].Value));
                        frm.lblDgvId.Text = classes.Id.ToString();
                        classes = context.Classes.Where(x => x.Id == classes.Id).FirstOrDefault();
                        txtClassName.Text = classes.ClassName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void List()
        {
            dgvClass.DataSource = classService.GetAll(x => x.IsActive == true);
            dgvClass.Columns["Id"].Visible = false;
            dgvClass.Columns["IsActive"].Visible = false;

            int i = 1;
            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save the changes ? ", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (classes.Id == 0)
                    {
                        classes.ClassName = txtClassName.Text.Trim();
                        classService.Add(classes);
                    }
                    else
                    {
                        var getClass = classService.Get(classes.Id);
                        getClass.ClassName = txtClassName.Text.Trim();
                        classService.UpdateOrDelete(getClass);
                    }
                    List();
                    Clear();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void dgvClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvClass.Rows.Count > 0)
                dgvClass.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete the class ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvClass.SelectedRows.Count == 1)
                    {
                        var getClass = classService.Get(classes.Id);
                        getClass.Id = (int)dgvClass.CurrentRow.Cells["Id"].Value;
                        getClass.IsActive = false;
                        classService.UpdateOrDelete(getClass);
                        List();
                        Clear();
                        dgvClass.ClearSelection();
                        MessageBox.Show("Successfully delete !");
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
            dgvClass.DataSource = classService.GetAll(x => x.ClassName.Contains(txtSearch.Text));

            dgvClass.Columns["Id"].Visible = false;
            dgvClass.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClass.SelectedRows.Count == 1)
                {
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Please select a class !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}
