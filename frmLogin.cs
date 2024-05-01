using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
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
    }
}
