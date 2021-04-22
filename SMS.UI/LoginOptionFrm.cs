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
    public partial class LoginOptionFrm : Form
    {
        public LoginOptionFrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        LoginFrm loginFrm = new LoginFrm();

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFrm.lblLoginId.Text = "0";
            loginFrm.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFrm.lblLoginId.Text = "1";
            loginFrm.ShowDialog();
        }
    }
}
