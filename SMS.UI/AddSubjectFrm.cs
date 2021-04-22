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

        SMSContext context = new SMSContext();
        IGenericService<Subjects> subjectService = new SubjectManager(new EFSubjectsDAL());

        private void AddSubjectFrm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            clbAdd.Items.Clear();
            clbDelete.Items.Clear();
            var classId = Convert.ToInt32(lblDgvId.Text);
            var classes = from c in context.Subjects
                          where c.Classes.Any(x => x.Id == classId)
                          select c;

            foreach (var item in classes)
            {
                clbDelete.Items.Add(item.SubjectName);
            }

            var addList = subjectService.GetAll();
            foreach (var item in addList)
            {
                clbAdd.Items.Add(item.SubjectName);
            }
            foreach (var item in clbDelete.Items.OfType<string>().ToList())
            {
                clbAdd.Items.Remove(item);
            }
        }
        private void cbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {

            foreach (var item in clbAdd.CheckedItems)
            {
                int classId = Convert.ToInt32(lblDgvId.Text);
                var classes = context.Classes.FirstOrDefault(x => x.Id == classId);
                var subjects = context.Subjects.Where(x => x.SubjectName == item.ToString()).FirstOrDefault();
                classes.Subjects.Add(subjects);
                context.SaveChanges();
            }
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in clbDelete.CheckedItems)
            {
                int classId = Convert.ToInt32(lblDgvId.Text);
                var classes = context.Classes.FirstOrDefault(x => x.Id == classId);
                var subjects = context.Subjects.Where(x => x.SubjectName == item.ToString()).FirstOrDefault();
                classes.Subjects.Remove(subjects);
                context.SaveChanges();
            }
            List();
        }
    }
}
