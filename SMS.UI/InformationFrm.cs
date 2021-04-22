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
    public partial class InformationFrm : Form
    {
        public InformationFrm()
        {
            InitializeComponent();
        }

        private void cbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
