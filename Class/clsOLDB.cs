using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MetroFramework;

namespace G.COMPUTERS_STUDENT_ALERT.Class
{
    class clsOLDB
    {

        OleDbCommand concmd = new OleDbCommand();
        OleDbDataAdapter condataadapter = new OleDbDataAdapter();

        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|db.mdb");

        public void checkcon()
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(frmmain.ActiveForm, e.Message);
            }

        }
        public void conClose(OleDbCommand cmdfunction)
        {
            cmdfunction.ExecuteNonQuery();
            cmdfunction.Parameters.Clear();
            cmdfunction.Connection.Close();
            con.Close();
        }

        public void conOpen(OleDbCommand cmdfunction)
        {
            checkcon();
            cmdfunction.Connection = con;
        }
        public void list_data_view(string sqlstr,ListView listview)
        {
            listview.Items.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlstr, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    for(int i = 1; i < dr.FieldCount; i++)
                    {
                        listitem.SubItems.Add(dr[i].ToString());
                    }
                    
                    listview.Items.Add(listitem);
                   

                }
                con.Close();
                cmd.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frmmain.ActiveForm, ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
