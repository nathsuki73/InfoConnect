namespace InfoConnect
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEventCount = new System.Windows.Forms.Label();
            this.lblAnnouncementCount = new System.Windows.Forms.Label();
            this.lblAdviser = new System.Windows.Forms.Label();
            this.lblGreet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(23, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 255);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(560, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 436);
            this.panel2.TabIndex = 0;
            // 
            // lblEventCount
            // 
            this.lblEventCount.AutoSize = true;
            this.lblEventCount.BackColor = System.Drawing.Color.Transparent;
            this.lblEventCount.Location = new System.Drawing.Point(134, 195);
            this.lblEventCount.Name = "lblEventCount";
            this.lblEventCount.Size = new System.Drawing.Size(35, 13);
            this.lblEventCount.TabIndex = 1;
            this.lblEventCount.Text = "label1";
            // 
            // lblAnnouncementCount
            // 
            this.lblAnnouncementCount.AutoSize = true;
            this.lblAnnouncementCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnouncementCount.Location = new System.Drawing.Point(324, 195);
            this.lblAnnouncementCount.Name = "lblAnnouncementCount";
            this.lblAnnouncementCount.Size = new System.Drawing.Size(35, 13);
            this.lblAnnouncementCount.TabIndex = 1;
            this.lblAnnouncementCount.Text = "label1";
            // 
            // lblAdviser
            // 
            this.lblAdviser.AutoSize = true;
            this.lblAdviser.BackColor = System.Drawing.Color.Transparent;
            this.lblAdviser.Location = new System.Drawing.Point(616, 75);
            this.lblAdviser.Name = "lblAdviser";
            this.lblAdviser.Size = new System.Drawing.Size(35, 13);
            this.lblAdviser.TabIndex = 1;
            this.lblAdviser.Text = "label1";
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.BackColor = System.Drawing.Color.Transparent;
            this.lblGreet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGreet.Location = new System.Drawing.Point(29, 22);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(35, 13);
            this.lblGreet.TabIndex = 1;
            this.lblGreet.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(337, -86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label1";
            // 
            // lblRealTime
            // 
            this.lblRealTime.AutoSize = true;
            this.lblRealTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRealTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRealTime.Location = new System.Drawing.Point(113, 596);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(35, 13);
            this.lblRealTime.TabIndex = 1;
            this.lblRealTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRealTime);
            this.Controls.Add(this.lblGreet);
            this.Controls.Add(this.lblAdviser);
            this.Controls.Add(this.lblAnnouncementCount);
            this.Controls.Add(this.lblEventCount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEventCount;
        private System.Windows.Forms.Label lblAnnouncementCount;
        private System.Windows.Forms.Label lblAdviser;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.Timer timer1;
    }
}