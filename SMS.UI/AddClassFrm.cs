using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
using SMS.DAL.Context;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.UI
{
    public partial class AddClassFrm : Form
    {
        public AddClassFrm()
        {
            InitializeComponent();
        }

        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        EFClassesDAL classesDAL = new EFClassesDAL();

        private void AddClassFrm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {

            var staffId = Convert.ToInt32(lblDgvId.Text);
            var classes = classService.GetAll(x => x.Staffs.Any(s => s.Id == staffId));

            dgvDeleteClasses.DataSource = classes;
            dgvAddClasses.DataSource = classesDAL.NonStaffClasses(staffId);
            dgvAddClasses.Columns["Id"].Visible = false;
            dgvAddClasses.Columns["IsActive"].Visible = false;
            dgvDeleteClasses.Columns["Id"].Visible = false;
            dgvDeleteClasses.Columns["IsActive"].Visible = false;
        }

        private void cbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdded_Click(object senderf, EventArgs e)
        {
            int staffId = Convert.ToInt32(lblDgvId.Text);
            for (int i = 0; i < dgvAddClasses.Rows.Count; i++)
            {
                if (dgvAddClasses.Rows[i].Cells["Add"].Value != null)
                {
                    int classId = Convert.ToInt32(dgvAddClasses.Rows[i].Cells["Id"].Value);
                    var a =classesDAL.AddStaffClasses(staffId, classId);
                }
            }
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int staffId = Convert.ToInt32(lblDgvId.Text);
            for (int i = 0; i < dgvDeleteClasses.Rows.Count; i++)
            {
                if (dgvDeleteClasses.Rows[i].Cells["Delete"].Value != null)
                {
                    int classId = Convert.ToInt32(dgvDeleteClasses.Rows[i].Cells["Id"].Value);
                    classesDAL.RemoveStaffClasses(staffId, classId);
                }
                
            }
            List();
        }
    }
}
