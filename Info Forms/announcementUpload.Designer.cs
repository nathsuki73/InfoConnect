namespace InfoConnect.Info_Forms
{
    partial class announcementUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(announcementUpload));
            this.btnOK = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.CheckedState.ImageSize = new System.Drawing.Size(81, 38);
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.HoverState.ImageSize = new System.Drawing.Size(81, 38);
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageSize = new System.Drawing.Size(81, 38);
            this.btnOK.Location = new System.Drawing.Point(77, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.PressedState.ImageSize = new System.Drawing.Size(81, 38);
            this.btnOK.PressedState.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(104, 48);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseTransparentBackground = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // announcementUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(253, 141);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "announcementUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPLOADED!";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnOK;
    }
}