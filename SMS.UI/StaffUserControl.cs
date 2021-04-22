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
using System.Data.Entity;

namespace SMS.UI
{
    public partial class StaffUserControl : UserControl
    {
        public StaffUserControl()
        {
            InitializeComponent();
        }

        AddClassFrm frm = new AddClassFrm();
        IGenericService<Roles> roleService = new RolesManager(new EFRolesDAL());
        IGenericService<Staffs> staffService = new StaffManager(new EFStaffsDAL());
        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());
        EFStaffsDAL staffsDAL = new EFStaffsDAL();
        Staffs staff = new Staffs();

        private void StaffUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            cmbRole.DataSource = roleService.GetAll();
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "Id";

            cmbSubject.DataSource = subjectService.GetAll();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "Id";
        }

        private void List()
        {
            dgvStaff.DataSource = staffsDAL.StaffList();

            dgvStaff.Columns["Id"].Visible = false;
            dgvStaff.Columns["IsActive"].Visible = false;
            dgvStaff.Columns["ClassName"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvStaff.Rows)
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
            dgvStaff.ClearSelection();
            staff = new Staffs();
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
                else if (item.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)item).ReadOnly = false;
                    item.Text = "0";
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
                else if (item.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)item).ReadOnly = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 1)
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
                    else if (item.GetType() == typeof(NumericUpDown))
                    {
                        ((NumericUpDown)item).ReadOnly = false;
                    }
                }
            }
            else
                MessageBox.Show("Please select a staff !");
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaff.SelectedRows.Count == 1)
                {
                    staff.Id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["Id"].Value);
                    frm.lblDgvId.Text = staff.Id.ToString();
                    txtFirstname.Text = dgvStaff.CurrentRow.Cells["Firstname"].Value.ToString();
                    txtLastname.Text = dgvStaff.CurrentRow.Cells["Lastname"].Value.ToString();
                    mskdIdentityNo.Text = dgvStaff.CurrentRow.Cells["IdentityNo"].Value.ToString();
                    txtUsername.Text = dgvStaff.CurrentRow.Cells["Username"].Value.ToString();
                    txtPassword.Text = dgvStaff.CurrentRow.Cells["Password"].Value.ToString();
                    dtpDateOfBirth.Value = (DateTime)dgvStaff.CurrentRow.Cells["BornDate"].Value;
                    mskdContactNo.Text = dgvStaff.CurrentRow.Cells["ContactNo"].Value.ToString();
                    nudSalary.Value = Convert.ToDecimal(dgvStaff.CurrentRow.Cells["Salary"].Value);
                    txtAddress.Text = dgvStaff.CurrentRow.Cells["Address"].Value.ToString();
                    cmbRole.Text = dgvStaff.CurrentRow.Cells["RoleName"].Value.ToString();
                    cmbSubject.Text = dgvStaff.CurrentRow.Cells["SubjectName"].Value.ToString();
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
                    if (staff.Id == 0)
                    {
                        staff.Firstname = txtFirstname.Text.Trim();
                        staff.Lastname = txtLastname.Text.Trim();
                        staff.IdentityNo = mskdIdentityNo.Text;
                        staff.Username = txtUsername.Text.Trim();
                        staff.Password = txtPassword.Text.Trim();
                        staff.BornDate = (DateTime)dtpDateOfBirth.Value;
                        staff.ContactNo = mskdContactNo.Text.Trim();
                        staff.Salary = (double)nudSalary.Value;
                        staff.Address = txtAddress.Text.Trim();
                        staff.RoleId = (int)cmbRole.SelectedValue;
                        staff.SubjectId = (int)cmbSubject.SelectedValue;
                        staffService.Add(staff);
                    }
                    else
                    {
                        var getStaff = staffService.Get(staff.Id);
                        getStaff.Firstname = txtFirstname.Text.Trim();
                        getStaff.Lastname = txtLastname.Text.Trim();
                        getStaff.IdentityNo = mskdIdentityNo.Text;
                        getStaff.Username = txtUsername.Text.Trim();
                        getStaff.Password = txtPassword.Text.Trim();
                        getStaff.BornDate = (DateTime)dtpDateOfBirth.Value;
                        getStaff.ContactNo = mskdContactNo.Text.Trim();
                        getStaff.Salary = (double)nudSalary.Value;
                        getStaff.Address = txtAddress.Text.Trim();
                        getStaff.RoleId = (int)cmbRole.SelectedValue;
                        getStaff.SubjectId = (int)cmbSubject.SelectedValue;
                        staffService.UpdateOrDelete(getStaff);
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

        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvStaff.Rows.Count > 0)
                dgvStaff.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to delete the staff ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvStaff.SelectedRows.Count == 1)
                    {
                        var getStaff = staffService.Get(staff.Id);
                        getStaff.Id = (int)dgvStaff.CurrentRow.Cells["Id"].Value;
                        getStaff.IsActive = false;
                        staffService.UpdateOrDelete(getStaff);
                        List();
                        Clear();
                        dgvStaff.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStaff.DataSource = staffsDAL.StaffList(txtSearch.Text);

            dgvStaff.Columns["Id"].Visible = false;
            dgvStaff.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.SelectedRows.Count == 1)
                {
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Please select a staff !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
