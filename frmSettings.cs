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
        public frmSettings()
        {
            InitializeComponent();
        }

        // disables the frmMain while the frmSettings is loaded (BUG: frmMain doesn't enable when the frmSettings is closed)
        private void frmSettings_Load(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Enabled = false;
        }


    }
}
