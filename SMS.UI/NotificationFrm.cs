using SMS.BLL.Abstracts;
using SMS.BLL.Concrete;
using SMS.DAL.Concrete.EntityFramework;
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
    public partial class NotificationFrm : Form
    {
        public NotificationFrm()
        {
            InitializeComponent();
        }
        IGenericService<StudentsMessage> studentMessageService = new StudentsMessageManager(new EFStudentsMessageDAL());
        EFStudentsMessageDAL studentsMessageDAL = new EFStudentsMessageDAL();
        StudentsMessage studentsMessage = new StudentsMessage();
        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMessage.Rows)
            {
                studentsMessage.Id = Convert.ToInt32(row.Cells["Id"].Value);
                var getStudentMessage = studentMessageService.Get(studentsMessage.Id);
                getStudentMessage.IsRead = true;
                studentMessageService.UpdateOrDelete(getStudentMessage);
            }
            this.Hide();
        }

        private void NotificationFrm_Load(object sender, EventArgs e)
        {
            dgvMessage.DataSource = studentsMessageDAL.GetMessages(StudentsManager.onlineStudent.Id);
            int i = 1;
            foreach (DataGridViewRow row in dgvMessage.Rows)
            {
                row.Cells["Row"].Value = i;
                i++;
            }
        }
    }
}
