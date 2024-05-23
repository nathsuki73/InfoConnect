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
    public partial class frmProfileView : Form
    {

        PrivateFontCollection privateFont = new PrivateFontCollection();

        public frmProfileView()
        {
            InitializeComponent();
            AddVisualFont();

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfileEdit Profile = new frmProfileEdit();
            Profile.Show();
        }

        

        private void frmProfileView_Load(object sender, EventArgs e)
        {

        }

        private void frmProfileView_Deactivate(object sender, EventArgs e)
        {
            this.Close();//Close form when focus is gone
        }

        private void AddVisualFont()
        {
            // Define the path to the font file
            string fontFilePathNath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
            string fontFilePathGio = "C:\\Users\\gioan\\OneDrive\\Pictures\\InfoConnect\\share-tech-mono\\ShareTechMono-Regular.ttf";


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
            lblFullName.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblCourseSection.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAboutMe.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblEmail.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAccountDateCreated.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);

        }
    }
}
