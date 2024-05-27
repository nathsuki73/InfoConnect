using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmEvents_create : Form
    {

        // Define the path to the font file
        string fontFilePathNath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
        string fontFilePathGio = "C:\\Users\\gioan\\OneDrive\\Pictures\\InfoConnect\\share-tech-mono\\ShareTechMono-Regular.ttf";

        PrivateFontCollection privateFont = new PrivateFontCollection();

        public frmEvents_create()
        {
            InitializeComponent();
            AddVisualFont();
        }

        private void AddVisualFont()
        {

            // CHanging Font here 
            if (File.Exists(fontFilePathNath))
            {
                privateFont.AddFontFile(fontFilePathNath);
            }
            else if (File.Exists(fontFilePathGio))
            {
                privateFont.AddFontFile(fontFilePathGio);
            }
            else
            {
                // Handle the case where neither font file exists
                throw new FileNotFoundException("The specified font files could not be found.");
            }

            // Create a new font using the private font collection
            txtDate.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtDescriptionEvent.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtImage.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtDate.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtTime.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtTitleEvent.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);


        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                txtImage.Text = selectedFilePath;
            }
        }

        private void txtTitleEvent_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = $"{txtTitleEvent.Text.Length}/60";
            txtTitleEvent.MaxLength = 60;
        }

        private void txtDescriptionEvent_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = $"{txtDescriptionEvent.Text.Length}/500";
            txtDescriptionEvent.MaxLength = 500;


        }

        private void frmEvents_create_Load(object sender, EventArgs e)
        {
        }
    }
}
