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
    public partial class RoleUserControl : UserControl
    {
        public RoleUserControl()
        {
            InitializeComponent();
        }

        IGenericService<Roles> roleService = new RolesManager(new EFRolesDAL());
        Roles role = new Roles();

        private void RoleUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            dgvRole.DataSource = roleService.GetAll(x => x.IsActive == true);
            dgvRole.Columns["Id"].Visible = false;
            dgvRole.Columns["IsActive"].Visible = false;

            int i = 1;
            foreach (DataGridViewRow row in dgvRole.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dgvRole.ClearSelection();
            role = new Roles();
        }

        private void Clear()
        {
            txtRoleName.ReadOnly = false;
            txtRoleName.Text = "";
        }

        private void Close()
        {
            txtRoleName.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count == 1)
            {
                txtRoleName.ReadOnly = false;
            }
            else
                MessageBox.Show("Please select a role !");
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRole.SelectedRows.Count == 1)
                {
                    role.Id = (int)dgvRole.CurrentRow.Cells["Id"].Value;
                    txtRoleName.Text = dgvRole.CurrentRow.Cells["RoleName"].Value.ToString();
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
                    if (role.Id == 0)
                    {
                        role.RoleName = txtRoleName.Text.Trim();
                        roleService.Add(role);
                    }
                    else
                    {
                        var getRole = roleService.Get(role.Id);
                        getRole.RoleName = txtRoleName.Text.Trim();
                        roleService.UpdateOrDelete(getRole);
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
            result = MessageBox.Show("Do you want to delete the role ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgvRole.SelectedRows.Count == 1)
                    {
                        var getRole = roleService.Get(role.Id);
                        getRole.Id = (int)dgvRole.CurrentRow.Cells["Id"].Value;
                        getRole.IsActive = false;
                        roleService.UpdateOrDelete(getRole);
                        List();
                        Clear();
                        dgvRole.ClearSelection();
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
            dgvRole.DataSource = roleService.GetAll(x => x.RoleName.Contains(txtSearch.Text));

            dgvRole.Columns["Id"].Visible = false;
            dgvRole.Columns["IsActive"].Visible = false;
            int i = 1;
            foreach (DataGridViewRow row in dgvRole.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }

        private void dgvRole_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvRole.Rows.Count > 0)
                dgvRole.Rows[0].Selected = false;
        }
    }
}
