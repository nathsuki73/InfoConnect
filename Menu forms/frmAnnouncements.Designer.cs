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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateAnnouncement = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 563);
            this.panel1.TabIndex = 0;
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
            this.btnCreateAnnouncement.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.btnCreateAnnouncement.PressedState.ImageSize = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.PressedState.Parent = this.btnCreateAnnouncement;
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(207, 53);
            this.btnCreateAnnouncement.TabIndex = 1;
            this.btnCreateAnnouncement.UseTransparentBackground = true;
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // frmAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 654);
            this.Controls.Add(this.btnCreateAnnouncement);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnnouncements";
            this.Text = "frmAnnouncements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnCreateAnnouncement;
    }
}