using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Data.OleDb;
namespace G.COMPUTERS_STUDENT_ALERT
{
    public partial class frmmain : MetroFramework.Forms.MetroForm
    {
        string studentname;
        string cource;
        string cometime;
        string s_ids;
        DateTime addhour = DateTime.Now.AddMilliseconds(3600000);
        //form
        frmclock frmclock = new frmclock();
        frmadmin frmadmin = new frmadmin();
        //counter timer
        Timer timer = new Timer();
        //class
        Class.clsOLDB conclass = new Class.clsOLDB();
        //oleDB connection commend
        OleDbCommand cmd = new OleDbCommand();
        public frmmain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            adminpanel.Visible = false;
            studentpanel.Visible = false;
        }

        private void btnsumbit(object sender, EventArgs e)
        {
            if (txtboxuser.Text=="")
            {
                MetroMessageBox.Show(this, "\n\nPLEASE ENTER YOUR NAME\nTO RECORD THE SESSION OF YOUR LEARING\n\n\n\n\n\n\n\n\nCopyright © Venus Foundation", "G. COMPUTERs STUDENT ALERT", MessageBoxButtons.OK,MessageBoxIcon.Information,387);
                txtboxuser.Focus();
            }
            else
            {
                if (txtpass.Text == "")
                {
                    MetroMessageBox.Show(this, "\n\nPLEASE ENTER YOUR COURCE NAME\nTO RECORD THE SESSION OF YOUR LEARING\n\n\n\n\n\n\n\n\nCopyright © Venus Foundation", "G. COMPUTERs STUDENT ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information, 387);
                    txtpass.Focus();
                }
                else
                {
                    timer.Interval = (30 * 1000);//1 hour
                    timer.Tick += new EventHandler(alertstart);
                    timer.Start();
                    this.Hide();
                    studentname = txtboxuser.Text;
                    cource = txtpass.Text;
                    cometime = DateTime.Now.ToString("t");
                    checkid();
                    student_user_save();
                    frmclock.Show();

                }
            }
        }
        
        private void student_user_save()
        {
            try
            {
                conclass.checkcon();
                conclass.conOpen(cmd);
                cmd.CommandText = "insert into userstudent(s_id, studentname, cources) values(?, ?, ?)";
                cmd.Parameters.Add("@s_id", OleDbType.Numeric).Value = this.s_ids;
                cmd.Parameters.Add("@studentname", OleDbType.Char).Value = this.txtboxuser.Text.Trim().ToUpper();
                cmd.Parameters.Add("@cources", OleDbType.Char).Value = this.txtpass.Text.Trim().ToUpper();

                conclass.conClose(cmd);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void checkid()
        {
            
            try
            {
                int myid;
                conclass.checkcon();
                OleDbCommand cmd = new OleDbCommand("select max(s_id) as ids from userstudent", conclass.con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {
                        s_ids = "1";
                    }
                    else
                    {
                        myid = Convert.ToInt32(dr["ids"]) + 1;
                        s_ids = myid.ToString();
                    }
                }
                dr.Close();
                conclass.con.Close();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            
            
        }
        private void alertstart(object sender,EventArgs e)
        {
            
            studentpanel.Visible = true;
            this.Show();
            frmclock.Hide();
            timer.Stop();
            stuname.Text = studentname.ToUpper();
            courcename.Text = cource.ToUpper();
            comingtime.Text = cometime;
            goigtime.Text = Convert.ToString(addhour.ToString("t"));
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            adminpanel.Visible = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            adminpanel.Visible = false;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            studentpanel.Visible = false;
            txtboxuser.Text = "";
            txtpass.Text = "";
            txtboxuser.Focus();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtaduserid.Text == "")
            {
                MetroMessageBox.Show(this, "\n\nPLEASE ENTER THE USER ID\nTO LOGIN IN ADMIN PANEL\n\n\n\n\n\n\n\n\nCopyright © Venus Foundation", "G. COMPUTERs STUDENT ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information, 387);
                txtaduserid.Focus();
            }
            else
            {
                if (txtadpass.Text == "")
                {
                    MetroMessageBox.Show(this, "\n\nPLEASE ENTER THE PASSWORD\nTO LOGIN IN ADMIN PANE\n\n\n\n\n\n\n\n\nCopyright © Venus Foundation", "G. COMPUTERs STUDENT ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information, 387);
                    txtadpass.Focus();
                }
                else
                {
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand("select * from login where userid='" + txtaduserid.Text + "'and password='" + txtadpass.Text + "'", conclass.con);
                        if (conclass.con.State == ConnectionState.Open)
                        {
                            conclass.con.Close();
                        }
                        conclass.con.Open();
                        OleDbDataReader dbreader = cmd.ExecuteReader();
                        if (dbreader.Read())
                        {
                            conclass.con.Close();
                            dbreader.Close();
                            cmd.Dispose();
                            this.Hide();
                            frmadmin.Show();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "\n\nPLEASE ENTER RIGHT USER ID AND PASSWORD\nAND TO LOGIN IN THE ADMIN PANEL\n\n\n\n\n\n\n\n\nCopyright © Venus Foundation", "G. COMPUTERs STUDENT ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information, 387);
                        }


                    }
                    catch (Exception exeption)
                    {
                        MessageBox.Show(exeption.Message);
                    }

                }
            }
            
        }
    }
}
