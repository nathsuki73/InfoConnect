using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect.Menu_forms
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
            FixDesign();
            DoubleBuffered = true;
        }

        private void FixDesign()
        {
           //pnlAboutUs.Parent = guna2PictureBox1;
        }

        private void frmAboutUs_Scroll(object sender, ScrollEventArgs e)
        {
            //DoubleBuffered = true;
        }
    }
}
