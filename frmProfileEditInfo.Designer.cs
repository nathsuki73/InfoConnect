namespace InfoConnect
{
    partial class frmProfileEditInfo
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
            this.pcbContainer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNewInfo = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbContainer
            // 
            this.pcbContainer.BackColor = System.Drawing.Color.Transparent;
            this.pcbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbContainer.Location = new System.Drawing.Point(0, 0);
            this.pcbContainer.Name = "pcbContainer";
            this.pcbContainer.ShadowDecoration.Parent = this.pcbContainer;
            this.pcbContainer.Size = new System.Drawing.Size(452, 349);
            this.pcbContainer.TabIndex = 0;
            this.pcbContainer.TabStop = false;
            this.pcbContainer.UseTransparentBackground = true;
            // 
            // txtNewInfo
            // 
            this.txtNewInfo.BorderThickness = 0;
            this.txtNewInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewInfo.DefaultText = "";
            this.txtNewInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewInfo.DisabledState.Parent = this.txtNewInfo;
            this.txtNewInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewInfo.FocusedState.Parent = this.txtNewInfo;
            this.txtNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewInfo.HoverState.Parent = this.txtNewInfo;
            this.txtNewInfo.Location = new System.Drawing.Point(11, 39);
            this.txtNewInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewInfo.Name = "txtNewInfo";
            this.txtNewInfo.PasswordChar = '\0';
            this.txtNewInfo.PlaceholderText = "";
            this.txtNewInfo.SelectedText = "";
            this.txtNewInfo.ShadowDecoration.Parent = this.txtNewInfo;
            this.txtNewInfo.Size = new System.Drawing.Size(50, 26);
            this.txtNewInfo.TabIndex = 2;
            // 
            // frmProfileEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.txtNewInfo);
            this.Controls.Add(this.pcbContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProfileEditInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfileEditInfo";
            this.Load += new System.EventHandler(this.frmProfileEditInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcbContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtNewInfo;
    }
}