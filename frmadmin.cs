using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.COMPUTERS_STUDENT_ALERT
{
    public partial class frmadmin : MetroFramework.Forms.MetroForm
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmmain frmmain = new frmmain();
            frmmain.Show();
            this.Close();
        }

        private void titleseestudent_Click(object sender, EventArgs e)
        {
            frmstudentlist frmstudentlist = new frmstudentlist();
            frmstudentlist.Show();
            this.Hide();
        }

        private void titledetails_Click(object sender, EventArgs e)
        {

        }

        private void titleaboutsoft_Click(object sender, EventArgs e)
        {

        }

        private void titleaddstudent_Click(object sender, EventArgs e)
        {

        }
    }
}
