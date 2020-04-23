namespace G.COMPUTERS_STUDENT_ALERT
{
    partial class frmadmin
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
            this.titleseestudent = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.titledetails = new MetroFramework.Controls.MetroTile();
            this.titleaboutsoft = new MetroFramework.Controls.MetroTile();
            this.titleaddstudent = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // titleseestudent
            // 
            this.titleseestudent.ActiveControl = null;
            this.titleseestudent.Location = new System.Drawing.Point(32, 70);
            this.titleseestudent.Name = "titleseestudent";
            this.titleseestudent.Size = new System.Drawing.Size(629, 185);
            this.titleseestudent.Style = MetroFramework.MetroColorStyle.Purple;
            this.titleseestudent.TabIndex = 0;
            this.titleseestudent.Text = "&SEE USER STUDENT";
            this.titleseestudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleseestudent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleseestudent.UseSelectable = true;
            this.titleseestudent.Click += new System.EventHandler(this.titleseestudent_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(10, 473);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(248, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Copyright © Venus Foundation";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btncancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(822, 455);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(140, 43);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "&CANCEL";
            this.btncancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // titledetails
            // 
            this.titledetails.ActiveControl = null;
            this.titledetails.Location = new System.Drawing.Point(32, 261);
            this.titledetails.Name = "titledetails";
            this.titledetails.Size = new System.Drawing.Size(312, 182);
            this.titledetails.Style = MetroFramework.MetroColorStyle.Yellow;
            this.titledetails.TabIndex = 6;
            this.titledetails.Text = "&SEE YOUR DETAILS OF STUDENT";
            this.titledetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titledetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titledetails.UseSelectable = true;
            this.titledetails.Click += new System.EventHandler(this.titledetails_Click);
            // 
            // titleaboutsoft
            // 
            this.titleaboutsoft.ActiveControl = null;
            this.titleaboutsoft.Location = new System.Drawing.Point(350, 261);
            this.titleaboutsoft.Name = "titleaboutsoft";
            this.titleaboutsoft.Size = new System.Drawing.Size(311, 182);
            this.titleaboutsoft.Style = MetroFramework.MetroColorStyle.Orange;
            this.titleaboutsoft.TabIndex = 7;
            this.titleaboutsoft.Text = "&ABOUT SOFTWARE";
            this.titleaboutsoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleaboutsoft.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleaboutsoft.UseSelectable = true;
            this.titleaboutsoft.Click += new System.EventHandler(this.titleaboutsoft_Click);
            // 
            // titleaddstudent
            // 
            this.titleaddstudent.ActiveControl = null;
            this.titleaddstudent.Location = new System.Drawing.Point(668, 70);
            this.titleaddstudent.Name = "titleaddstudent";
            this.titleaddstudent.Size = new System.Drawing.Size(276, 373);
            this.titleaddstudent.Style = MetroFramework.MetroColorStyle.Teal;
            this.titleaddstudent.TabIndex = 8;
            this.titleaddstudent.Text = "&ADD STUDENT";
            this.titleaddstudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleaddstudent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleaddstudent.UseSelectable = true;
            this.titleaddstudent.Click += new System.EventHandler(this.titleaddstudent_Click);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 507);
            this.ControlBox = false;
            this.Controls.Add(this.titleaddstudent);
            this.Controls.Add(this.titleaboutsoft);
            this.Controls.Add(this.titledetails);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.titleseestudent);
            this.Name = "frmadmin";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "WELCOME TO ADMIN PANEL";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile titleseestudent;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroTile titledetails;
        private MetroFramework.Controls.MetroTile titleaboutsoft;
        private MetroFramework.Controls.MetroTile titleaddstudent;
    }
}