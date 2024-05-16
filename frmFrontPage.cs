using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmFrontPage : Form
    {
                string connectionString = "datasource=192.168.1.18;port=3306;username=root;password=;database=dbstudio";

        public frmFrontPage()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form frmSignup = new frmSignup();
            frmSignup.Show();
        }

        private void frmFrontPage_Load(object sender, EventArgs e)
        {

        }
    }
}
