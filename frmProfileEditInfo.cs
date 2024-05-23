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
    public partial class frmProfileEditInfo : Form
    {
        public frmProfileEditInfo(Size newFormSize, Image newImageContainer)
        {
            InitializeComponent();
            //1366,768
            //1350, 729
            // 16, 37  // additional size when I changed the Formborderstyle
            int formWidth = newFormSize.Width + 16;
            int formHeight = newFormSize.Height + 37;
            this.Size = new Size(formWidth, formHeight);
            pcbContainer.Image = newImageContainer;

            //txtNewInfo.Location = newLocation;
            txtNewInfo.Width = newFormSize.Width - 20;
            
        }

        private void frmProfileEditInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
