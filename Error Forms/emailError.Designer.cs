﻿namespace InfoConnect.Error_Forms
{
    partial class emailError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailError));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.CheckedState.Image")));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(81, 38);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(81, 38);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(81, 38);
            this.guna2ImageButton1.Location = new System.Drawing.Point(85, 92);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(81, 38);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(92, 48);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // emailError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(253, 141);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "emailError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOPS!";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}