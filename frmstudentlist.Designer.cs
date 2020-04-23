namespace G.COMPUTERS_STUDENT_ALERT
{
    partial class frmstudentlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnback = new MetroFramework.Controls.MetroButton();
            this.userstudentlist = new MetroFramework.Controls.MetroListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnback.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnback.Highlight = true;
            this.btnback.Location = new System.Drawing.Point(728, 481);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(140, 43);
            this.btnback.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnback.TabIndex = 6;
            this.btnback.Text = "&BACK";
            this.btnback.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnback.UseSelectable = true;
            this.btnback.UseStyleColors = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // userstudentlist
            // 
            this.userstudentlist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.userstudentlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.studentname,
            this.cource});
            this.userstudentlist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userstudentlist.FullRowSelect = true;
            this.userstudentlist.LabelWrap = false;
            this.userstudentlist.Location = new System.Drawing.Point(23, 53);
            this.userstudentlist.Name = "userstudentlist";
            this.userstudentlist.ShowItemToolTips = true;
            this.userstudentlist.Size = new System.Drawing.Size(831, 422);
            this.userstudentlist.Style = MetroFramework.MetroColorStyle.Purple;
            this.userstudentlist.TabIndex = 7;
            this.userstudentlist.UseCompatibleStateImageBehavior = false;
            this.userstudentlist.UseSelectable = true;
            this.userstudentlist.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 151;
            // 
            // studentname
            // 
            this.studentname.Text = "STUDENT NAME";
            this.studentname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentname.Width = 333;
            // 
            // cource
            // 
            this.cource.Text = "COURCES";
            this.cource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cource.Width = 342;
            // 
            // frmstudentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 534);
            this.ControlBox = false;
            this.Controls.Add(this.userstudentlist);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmstudentlist";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "USER STUDENT LIST";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmstudentlist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnback;
        private MetroFramework.Controls.MetroListView userstudentlist;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader studentname;
        private System.Windows.Forms.ColumnHeader cource;
    }
}