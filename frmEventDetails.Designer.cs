namespace InfoConnect
{
    partial class frmEventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventDetails));
            this.btnEventInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnEventInfo.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.CheckedState.Image")));
            this.btnEventInfo.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEventInfo.CheckedState.Parent = this.btnEventInfo;
            this.btnEventInfo.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.btnEventInfo.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEventInfo.HoverState.Parent = this.btnEventInfo;
            this.btnEventInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEventInfo.Image")));
            this.btnEventInfo.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEventInfo.Location = new System.Drawing.Point(893, 472);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.btnEventInfo.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEventInfo.PressedState.Parent = this.btnEventInfo;
            this.btnEventInfo.Size = new System.Drawing.Size(31, 32);
            this.btnEventInfo.TabIndex = 1;
            this.btnEventInfo.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(41, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 243);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // frmEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(963, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEventInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventDetails";
            this.Text = "frmEventDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnEventInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}