namespace InfoConnect.Menu_forms
{
    partial class frmAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnnouncements));
            this.btnCreateAnnouncement = new Guna.UI2.WinForms.Guna2ImageButton();
            this.frmPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCreateAnnouncement
            // 
            this.btnCreateAnnouncement.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAnnouncement.CheckedState.Parent = this.btnCreateAnnouncement;
            this.btnCreateAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAnnouncement.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAnnouncement.HoverState.Image")));
            this.btnCreateAnnouncement.HoverState.ImageSize = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.HoverState.Parent = this.btnCreateAnnouncement;
            this.btnCreateAnnouncement.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAnnouncement.Image")));
            this.btnCreateAnnouncement.ImageSize = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.Location = new System.Drawing.Point(841, 589);
            this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            this.btnCreateAnnouncement.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAnnouncement.PressedState.Image")));
            this.btnCreateAnnouncement.PressedState.ImageSize = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.PressedState.Parent = this.btnCreateAnnouncement;
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.TabIndex = 1;
            this.btnCreateAnnouncement.UseTransparentBackground = true;
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // frmPanel
            // 
            this.frmPanel.BackColor = System.Drawing.Color.Transparent;
            this.frmPanel.Location = new System.Drawing.Point(12, 12);
            this.frmPanel.Name = "frmPanel";
            this.frmPanel.Size = new System.Drawing.Size(1036, 563);
            this.frmPanel.TabIndex = 0;
            // 
            // frmAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 654);
            this.Controls.Add(this.btnCreateAnnouncement);
            this.Controls.Add(this.frmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnnouncements";
            this.Text = "frmAnnouncements";
            this.Load += new System.EventHandler(this.frmAnnouncements_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnCreateAnnouncement;
        private System.Windows.Forms.Panel frmPanel;
    }
}