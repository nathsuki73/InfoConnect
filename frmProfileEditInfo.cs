using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmProfileEditInfo : Form
    {
        // Define the path to the font file
        string fontFilePath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
        PrivateFontCollection privateFont = new PrivateFontCollection();

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

            //365, 175
            if (newFormSize == new Size(365, 175))
            {
                txtNewInfo.Width = newFormSize.Width - 22;
                txtNewInfo.Height = 100;
                txtNewInfo.Multiline = true;
                txtNewInfo.MaxLength = 184;
                lbltextCount.Location = new Point(300, 140);
                lbltextCount.Visible = true;
            }
            else
            {
                txtNewInfo.Width = newFormSize.Width - 20;
            }

            privateFont.AddFontFile(fontFilePath);

            // Create a new font using the private font collection
            txtNewInfo.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            lbltextCount.Font = new Font(privateFont.Families[0], 7, FontStyle.Regular);

        }

        private void frmProfileEditInfo_Load(object sender, EventArgs e)
        {
            lbltextCount.Text = $"{txtNewInfo.Text.Length}/184";

        }

        private void frmProfileEditInfo_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewInfo_TextChanged(object sender, EventArgs e)
        {
            lbltextCount.Text = $"{txtNewInfo.Text.Length}/184";
        }
    }
}
