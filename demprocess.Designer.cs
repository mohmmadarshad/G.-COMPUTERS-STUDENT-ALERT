namespace G.COMPUTERS_STUDENT_ALERT
{
    partial class frmprocess
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Processing...";
            this.metroLabel1.UseWaitCursor = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(32, 42);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(64, 64);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            // 
            // frmprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 118);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroLabel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmprocess";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}