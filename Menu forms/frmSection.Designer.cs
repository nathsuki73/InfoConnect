namespace InfoConnect.Menu_forms
{
    partial class frmSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSection));
            this.ucAccountDisplay1 = new InfoConnect.ucAccountDisplay();
            this.SuspendLayout();
            // 
            // ucAccountDisplay1
            // 
            this.ucAccountDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.ucAccountDisplay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucAccountDisplay1.BackgroundImage")));
            this.ucAccountDisplay1.Location = new System.Drawing.Point(31, 63);
            this.ucAccountDisplay1.Name = "ucAccountDisplay1";
            this.ucAccountDisplay1.Size = new System.Drawing.Size(1006, 72);
            this.ucAccountDisplay1.TabIndex = 0;
            this.ucAccountDisplay1.TextFirstName = "Tangena";
            // 
            // frmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 654);
            this.Controls.Add(this.ucAccountDisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSection";
            this.Text = "frmSection";
            this.Load += new System.EventHandler(this.frmSection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucAccountDisplay ucAccountDisplay1;
    }
}