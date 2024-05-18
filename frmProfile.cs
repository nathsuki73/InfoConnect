using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmProfile : Form
    {
        private frmMain frmmain;
        public frmProfile(frmMain frmMain)
        {
            InitializeComponent();
            this.frmmain = frmMain;
        }

        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            frmmain.Enabled = false;
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmain.Enabled = true;
        }
    }
}
