namespace InfoConnect
{
    partial class ucAnnouncement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAnnouncement));
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.lblhehe = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(18, 15);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(35, 13);
            this.lblAnnouncementTitle.TabIndex = 0;
            this.lblAnnouncementTitle.Text = "label1";
            this.lblAnnouncementTitle.Click += new System.EventHandler(this.lblDate_Click);
            this.lblAnnouncementTitle.MouseLeave += new System.EventHandler(this.lblAnnouncementTitle_MouseLeave);
            this.lblAnnouncementTitle.MouseHover += new System.EventHandler(this.lblAnnouncementTitle_MouseHover);
            // 
            // lblhehe
            // 
            this.lblhehe.AutoSize = true;
            this.lblhehe.Location = new System.Drawing.Point(18, 50);
            this.lblhehe.Name = "lblhehe";
            this.lblhehe.Size = new System.Drawing.Size(292, 13);
            this.lblhehe.TabIndex = 0;
            this.lblhehe.Text = "Click Here To View More Details About This  Announcement";
            this.lblhehe.Click += new System.EventHandler(this.lblhehe_Click);
            this.lblhehe.MouseLeave += new System.EventHandler(this.lblhehe_MouseLeave);
            this.lblhehe.MouseHover += new System.EventHandler(this.lblhehe_MouseHover);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.lblTime.Location = new System.Drawing.Point(855, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time: 00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            this.lblTime.MouseLeave += new System.EventHandler(this.lblTime_MouseLeave);
            this.lblTime.MouseHover += new System.EventHandler(this.lblTime_MouseHover);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.lblDate.Location = new System.Drawing.Point(855, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            this.lblDate.MouseLeave += new System.EventHandler(this.lblDate_MouseLeave);
            this.lblDate.MouseHover += new System.EventHandler(this.lblDate_MouseHover);
            // 
            // ucAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblhehe);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucAnnouncement";
            this.Size = new System.Drawing.Size(1006, 72);
            this.Click += new System.EventHandler(this.ucAnnouncement_Click);
            this.MouseLeave += new System.EventHandler(this.ucAnnouncement_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucAnnouncement_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnouncementTitle;
        private System.Windows.Forms.Label lblhehe;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}
