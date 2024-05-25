namespace InfoConnect
{
    partial class frmannouncementDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmannouncementDetails));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(68, 96);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(68, 493);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(819, 493);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Location = new System.Drawing.Point(368, 493);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(68, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(65, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 3);
            this.panel1.TabIndex = 1;
            // 
            // frmannouncementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmannouncementDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmannouncementDetails";
            this.Load += new System.EventHandler(this.frmannouncementDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
    }
}