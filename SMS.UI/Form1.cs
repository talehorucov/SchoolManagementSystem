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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IGenericService<Classes> classesService = new ClassesManager(new EFClassesDAL());
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllClasses();
        }
        Classes classes = new Classes();
        private void button1_Click(object sender, EventArgs e)
        {
            classes.ClassName = textBox1.Text;
            //classesService.Add(classes);

            GetAllClasses();
        }
        private void GetAllClasses()
        {
            dataGridView1.DataSource = classesService.GetAll();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == dataGridView1.NewRowIndex)
            {
                button2.Text = "aaaa";
            }
            else
            {
                button2.Text = "bbbbb";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "ccccc";
        }
    }
}
