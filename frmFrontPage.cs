﻿using System;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmFrontPage : Form
    {
        public frmFrontPage()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
