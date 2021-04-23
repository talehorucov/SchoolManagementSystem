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
    public partial class AddSubjectFrm : Form
    {
        public AddSubjectFrm()
        {
            InitializeComponent();
        }

        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());
        EFSubjectsDAL subjectDAL = new EFSubjectsDAL();

        private void AddSubjectFrm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {

            var classId = Convert.ToInt32(lblDgvId.Text);
            var subject = subjectService.GetAll(x => x.Classes.Any(c => c.Id == classId));

            dgvDeleteSubjects.DataSource = subject;
            dgvAddSubjects.DataSource = subjectDAL.NonSubjectClasses(classId);
            dgvAddSubjects.Columns["Id"].Visible = false;
            dgvAddSubjects.Columns["IsActive"].Visible = false;
            dgvDeleteSubjects.Columns["Id"].Visible = false;
            dgvDeleteSubjects.Columns["IsActive"].Visible = false;
        }

        private void cbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(lblDgvId.Text);
            for (int i = 0; i < dgvAddSubjects.Rows.Count; i++)
            {
                if (dgvAddSubjects.Rows[i].Cells["Add"].Value != null)
                {
                    int subjectId = Convert.ToInt32(dgvAddSubjects.Rows[i].Cells["Id"].Value);
                    var a = subjectDAL.AddSubjectClasses(subjectId, classId);
                }
            }
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(lblDgvId.Text);
            for (int i = 0; i < dgvDeleteSubjects.Rows.Count; i++)
            {
                if (dgvDeleteSubjects.Rows[i].Cells["Delete"].Value != null)
                {
                    int subjectId = Convert.ToInt32(dgvDeleteSubjects.Rows[i].Cells["Id"].Value);
                    subjectDAL.RemoveSubjectClasses(subjectId, classId);
                }
            }
            List();
        }
    }
}
