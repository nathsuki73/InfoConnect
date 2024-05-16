namespace InfoConnect
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnProfileBack = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1225, 569);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnProfileBack
            // 
            this.btnProfileBack.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileBack.CheckedState.Parent = this.btnProfileBack;
            this.btnProfileBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileBack.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileBack.HoverState.Image")));
            this.btnProfileBack.HoverState.ImageSize = new System.Drawing.Size(106, 55);
            this.btnProfileBack.HoverState.Parent = this.btnProfileBack;
            this.btnProfileBack.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileBack.Image")));
            this.btnProfileBack.ImageSize = new System.Drawing.Size(106, 55);
            this.btnProfileBack.Location = new System.Drawing.Point(1099, 501);
            this.btnProfileBack.Name = "btnProfileBack";
            this.btnProfileBack.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileBack.PressedState.Image")));
            this.btnProfileBack.PressedState.ImageSize = new System.Drawing.Size(106, 55);
            this.btnProfileBack.PressedState.Parent = this.btnProfileBack;
            this.btnProfileBack.Size = new System.Drawing.Size(114, 56);
            this.btnProfileBack.TabIndex = 1;
            this.btnProfileBack.UseTransparentBackground = true;
            this.btnProfileBack.Click += new System.EventHandler(this.btnProfileBack_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 569);
            this.Controls.Add(this.btnProfileBack);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton btnProfileBack;
    }
}