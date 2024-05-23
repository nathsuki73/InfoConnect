namespace InfoConnect
{
    partial class frmProfileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfileView));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCourseSection = new System.Windows.Forms.Label();
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAccountDateCreated = new System.Windows.Forms.Label();
            this.btnEditProfile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 44);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(126, 122);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Location = new System.Drawing.Point(149, 68);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 13);
            this.lblFullName.TabIndex = 15;
            this.lblFullName.Text = "lblFullName";
            // 
            // lblCourseSection
            // 
            this.lblCourseSection.AutoSize = true;
            this.lblCourseSection.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseSection.Location = new System.Drawing.Point(149, 99);
            this.lblCourseSection.Name = "lblCourseSection";
            this.lblCourseSection.Size = new System.Drawing.Size(86, 13);
            this.lblCourseSection.TabIndex = 15;
            this.lblCourseSection.Text = "lblCourseSection";
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.AutoSize = true;
            this.lblAboutMe.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutMe.Location = new System.Drawing.Point(63, 254);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(86, 13);
            this.lblAboutMe.TabIndex = 15;
            this.lblAboutMe.Text = "lblCourseSection";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(63, 348);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "lblCourseSection";
            // 
            // lblAccountDateCreated
            // 
            this.lblAccountDateCreated.AutoSize = true;
            this.lblAccountDateCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDateCreated.Location = new System.Drawing.Point(63, 416);
            this.lblAccountDateCreated.Name = "lblAccountDateCreated";
            this.lblAccountDateCreated.Size = new System.Drawing.Size(86, 13);
            this.lblAccountDateCreated.TabIndex = 15;
            this.lblAccountDateCreated.Text = "lblCourseSection";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.CheckedState.Parent = this.btnEditProfile;
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.btnEditProfile.HoverState.Parent = this.btnEditProfile;
            this.btnEditProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProfile.Image")));
            this.btnEditProfile.Location = new System.Drawing.Point(367, 21);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.btnEditProfile.PressedState.Parent = this.btnEditProfile;
            this.btnEditProfile.Size = new System.Drawing.Size(20, 20);
            this.btnEditProfile.TabIndex = 16;
            this.btnEditProfile.UseTransparentBackground = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.HoverState.Image")));
            this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(66, 23);
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(66, 23);
            this.btnLogout.Location = new System.Drawing.Point(169, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.PressedState.Image")));
            this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(66, 23);
            this.btnLogout.PressedState.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(66, 23);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.UseTransparentBackground = true;
            // 
            // frmProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 556);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.lblAccountDateCreated);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAboutMe);
            this.Controls.Add(this.lblCourseSection);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfileView";
            this.Text = "Profile    ";
            this.Deactivate += new System.EventHandler(this.frmProfileView_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCourseSection;
        private System.Windows.Forms.Label lblAboutMe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAccountDateCreated;
        private Guna.UI2.WinForms.Guna2ImageButton btnEditProfile;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
    }
}