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
    public partial class MessageFrm : Form
    {
        public MessageFrm()
        {
            InitializeComponent();
        }
        IGenericService<Classes> classService = new ClassesManager(new EFClassesDAL());
        IGenericService<Students> studentService = new StudentsManager(new EFStudentsDAL());
        IGenericService<Messages> messageService = new MessagesManager(new EFMessagesDAL());
        IGenericService<StudentsMessage> studentsMessageService = new StudentsMessageManager(new EFStudentsMessageDAL());
        Messages messages = new Messages();
        StudentsMessage studentsMessage = new StudentsMessage();

        private void MessageFrm_Load(object sender, EventArgs e)
        {
            cmbClasses.DataSource = classService.GetAll(x => x.IsActive == true && x.Staffs.Any(a => a.Id == StaffManager.onlineStaff.StaffId));
            cmbClasses.DisplayMember = "ClassName";
            cmbClasses.ValueMember = "Id";

            cmbClasses.SelectedIndex = -1;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                messages.StaffId = StaffManager.onlineStaff.StaffId;
                messages.ClassId = Convert.ToInt32(cmbClasses.SelectedValue);
                messages.Title = txtTitle.Text;
                messages.Text = txtText.Text;
                messageService.Add(messages);


                var students = studentService.GetAll(x => x.ClassId == messages.ClassId);
                foreach (var item in students)
                {
                    studentsMessage.StudentId = item.Id;
                    studentsMessage.MessageId = messages.Id;
                    studentsMessageService.Add(studentsMessage);
                }

                MessageBox.Show("Message sent succesfully");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
