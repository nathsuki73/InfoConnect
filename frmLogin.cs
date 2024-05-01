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
            guna2TextBox1.Parent = guna2PictureBox1;
            guna2TextBox2.Parent = guna2PictureBox1;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
