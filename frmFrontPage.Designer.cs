namespace InfoConnect
{
    partial class frmFrontPage
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::InfoConnect.Properties.Resources.welcome_page_bg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1350, 729);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.CheckedState.Parent = this.btnLogIn;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.HoverState.Image = global::InfoConnect.Properties.Resources.btn_login_hover;
            this.btnLogIn.HoverState.ImageSize = new System.Drawing.Size(236, 66);
            this.btnLogIn.HoverState.Parent = this.btnLogIn;
            this.btnLogIn.Image = global::InfoConnect.Properties.Resources.btn_login_default;
            this.btnLogIn.ImageSize = new System.Drawing.Size(236, 66);
            this.btnLogIn.Location = new System.Drawing.Point(415, 573);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.PressedState.Image = global::InfoConnect.Properties.Resources.btn_login_hover;
            this.btnLogIn.PressedState.ImageSize = new System.Drawing.Size(236, 66);
            this.btnLogIn.PressedState.Parent = this.btnLogIn;
            this.btnLogIn.Size = new System.Drawing.Size(236, 66);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.UseTransparentBackground = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.CheckedState.Parent = this.btnSignUp;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.HoverState.Image = global::InfoConnect.Properties.Resources.btn_signup_hover;
            this.btnSignUp.HoverState.ImageSize = new System.Drawing.Size(236, 66);
            this.btnSignUp.HoverState.Parent = this.btnSignUp;
            this.btnSignUp.Image = global::InfoConnect.Properties.Resources.btn_signup_default;
            this.btnSignUp.ImageSize = new System.Drawing.Size(236, 66);
            this.btnSignUp.Location = new System.Drawing.Point(694, 573);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.PressedState.Image = global::InfoConnect.Properties.Resources.btn_signup_hover;
            this.btnSignUp.PressedState.ImageSize = new System.Drawing.Size(236, 66);
            this.btnSignUp.PressedState.Parent = this.btnSignUp;
            this.btnSignUp.Size = new System.Drawing.Size(236, 66);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.UseTransparentBackground = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmFrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoConnect";
            this.Load += new System.EventHandler(this.frmFrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogIn;
        private Guna.UI2.WinForms.Guna2ImageButton btnSignUp;
    }
}

