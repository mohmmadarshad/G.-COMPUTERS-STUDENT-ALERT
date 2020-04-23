namespace G.COMPUTERS_STUDENT_ALERT
{
    partial class frmclock
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
            this.lbldate = new MetroFramework.Controls.MetroLabel();
            this.lbltime = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btntopmostflase = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(1, 8);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(95, 19);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "DD-MM-YYYY";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbltime.Font = new System.Drawing.Font("Museo", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(11, 19);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(243, 63);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "00:00:00";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(155, 78);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(162, 15);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Copyright © Venus Foundation";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btntopmostflase
            // 
            this.btntopmostflase.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btntopmostflase.Highlight = true;
            this.btntopmostflase.Location = new System.Drawing.Point(293, 7);
            this.btntopmostflase.Name = "btntopmostflase";
            this.btntopmostflase.Size = new System.Drawing.Size(22, 20);
            this.btntopmostflase.Style = MetroFramework.MetroColorStyle.Purple;
            this.btntopmostflase.TabIndex = 7;
            this.btntopmostflase.Text = "D";
            this.btntopmostflase.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btntopmostflase.UseSelectable = true;
            this.btntopmostflase.UseStyleColors = true;
            this.btntopmostflase.Click += new System.EventHandler(this.btntopmostflase_Click);
            // 
            // frmclock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 96);
            this.ControlBox = false;
            this.Controls.Add(this.btntopmostflase);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbltime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmclock";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmclock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbldate;
        private System.Windows.Forms.Label lbltime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btntopmostflase;
    }
}