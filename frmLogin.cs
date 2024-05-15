using System;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FixDesign();
        }
        private void FixDesign()
        {
            //para maging transparent background nung textbox
            txtEmail.Parent = guna2PictureBox1;
            txtPassword.Parent = guna2PictureBox1;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "12345")
            {
                frmMain main = new frmMain();
                main.Show();
            }
        }
    }
}
