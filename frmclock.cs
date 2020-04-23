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
    public partial class frmclock : MetroFramework.Forms.MetroForm
    {
        public frmclock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Bottom - this.Height);
                    return;
                }
            }
        }

        private void frmclock_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lbltime.Text = DateTime.Now.ToString("T");
                lbldate.Text = DateTime.Now.ToString("dddd dd-MMMM-yyyy");
            }));
        }

        private void btntopmostflase_Click(object sender, EventArgs e)
        {
            frmclock.ActiveForm.TopMost = false;
        }
    }
}
