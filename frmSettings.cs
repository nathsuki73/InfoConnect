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
    public partial class frmSettings : Form
    {
        private frmMain frmmain;
        public frmSettings(frmMain frmMain)
        {
            InitializeComponent();
            this.frmmain = frmMain;
        }

        // disables the frmMain while the frmSettings is loaded (BUG: frmMain doesn't enable when the frmSettings is closed)
        private void frmSettings_Load(object sender, EventArgs e)
        {
            frmmain.Enabled = false;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmain.Enabled = true;
        }
    }
}
