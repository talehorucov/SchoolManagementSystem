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
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.Entities.Entity;
using SMS.DAL.Context;
using SMS.Entities.ComplexTypes;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SMS.UI
{
    public partial class StudentUserControl : UserControl
    {
        public StudentUserControl()
        {
            InitializeComponent();
        }

        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        IGenericService<Students> studentService = new StudentsManager(new EFStudentsDAL());
        EFStudentsDAL studentsDAL = new EFStudentsDAL();

        Students student = new Students();

        private void StudentUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            cmbClass.DataSource = classService.GetAll();
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "Id";
        }

        private void List()
        {
            dgvStudent.DataSource = studentsDAL.StudentsList();

            dgvStudent.Columns["Id"].Visible = false;
            dgvStudent.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dgvStudent.ClearSelection();
            student = new Students();
        }

        private void Clear()
        {
            foreach (Control item in pnlLeft.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).ReadOnly = false;
                    item.Text = "";
                }
                else if (item.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)item).ReadOnly = false;
                    item.Text = "";
                }

            }
        }

        private void Close()
        {
            foreach (Control item in pnlLeft.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).ReadOnly = true;
                }
                else if (item.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)item).ReadOnly = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 1)
            {
                foreach (Control item in pnlLeft.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).ReadOnly = false;
                    }
                    else if (item.GetType() == typeof(MaskedTextBox))
                    {
                        ((MaskedTextBox)item).ReadOnly = false;
                    }
                }
            }
            else
                MessageBox.Show("Please select a student !");
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.SelectedRows.Count == 1)
                {
                    student.Id = (int)dgvStudent.CurrentRow.Cells["Id"].Value;
                    txtFirstname.Text = dgvStudent.CurrentRow.Cells["Firstname"].Value.ToString();
                    txtLastname.Text = dgvStudent.CurrentRow.Cells["Lastname"].Value.ToString();
                    txtFatherName.Text = dgvStudent.CurrentRow.Cells["FatherName"].Value.ToString();
                    txtUsername.Text = dgvStudent.CurrentRow.Cells["Username"].Value.ToString();
                    txtPassword.Text = dgvStudent.CurrentRow.Cells["Password"].Value.ToString();
                    dtpDateOfBirth.Value = (DateTime)dgvStudent.CurrentRow.Cells["BornDate"].Value;
                    mskdContactNo.Text = dgvStudent.CurrentRow.Cells["ContactNo"].Value.ToString();
                    txtAddress.Text = dgvStudent.CurrentRow.Cells["Address"].Value.ToString();
                    cmbClass.Text = dgvStudent.CurrentRow.Cells["ClassName"].Value.ToString();
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
                    if (student.Id == 0)
                    {
                        student.Firstname = txtFirstname.Text.Trim();
                        student.Lastname = txtLastname.Text.Trim();
                        student.FatherName = txtFatherName.Text.Trim();
                        student.Username = txtUsername.Text.Trim();
                        student.Password = txtPassword.Text.Trim();
                        student.BornDate = (DateTime)dtpDateOfBirth.Value;
                        student.ContactNo = mskdContactNo.Text.Trim();
                        student.Address = txtAddress.Text.Trim();
                        student.ClassId = (int)cmbClass.SelectedValue;
                        studentService.Add(student);
                    }
                    else
                    {
                        var getStudent = studentService.Get(student.Id);
                        getStudent.Firstname = txtFirstname.Text.Trim();
                        getStudent.Lastname = txtLastname.Text.Trim();
                        getStudent.FatherName = txtFatherName.Text.Trim();
                        getStudent.Username = txtUsername.Text.Trim();
                        getStudent.Password = txtPassword.Text.Trim();
                        getStudent.BornDate = (DateTime)dtpDateOfBirth.Value;
                        getStudent.ContactNo = mskdContactNo.Text.Trim();
                        getStudent.Address = txtAddress.Text.Trim();
                        getStudent.ClassId = (int)cmbClass.SelectedValue;
                        studentService.UpdateOrDelete(getStudent);
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

        private void dgvStudent_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvStudent.Rows.Count > 0)
                dgvStudent.Rows[0].Selected = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudent.DataSource = studentsDAL.StudentsList(txtSearch.Text);
            dgvStudent.Columns["Id"].Visible = false;
            dgvStudent.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete the student ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvStudent.SelectedRows.Count == 1)
                    {
                        var getStudent = studentService.Get(student.Id);
                        getStudent.Id = (int)dgvStudent.CurrentRow.Cells["Id"].Value;
                        getStudent.IsActive = false;
                        studentService.UpdateOrDelete(getStudent);
                        List();
                        Clear();
                        dgvStudent.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !", ex.Message);
                }
            }
        }
    }
}
