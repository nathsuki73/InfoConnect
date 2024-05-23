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
    public partial class frmProfileView : Form
    {
        public frmProfileView()
        {
            InitializeComponent();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfileEdit Profile = new frmProfileEdit();
            Profile.Show();
        }

        private void frmProfileView_Deactivate(object sender, EventArgs e)
        {
            this.Close();//Close form when focus is gone
        }
    }
}
