using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;

namespace G.COMPUTERS_STUDENT_ALERT
{
    public partial class frmstudentlist : MetroFramework.Forms.MetroForm
    {
        //class
        Class.clsOLDB conclass = new Class.clsOLDB();

        public frmstudentlist()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadmin frmadmin = new frmadmin();
            frmadmin.Show();
            this.Dispose();
        }

        private void frmstudentlist_Load(object sender, EventArgs e)
        {
            this.conclass.list_data_view("select * from userstudent", this.userstudentlist);

        }

    }
}
