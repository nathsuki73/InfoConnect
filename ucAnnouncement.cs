using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class ucAnnouncement : UserControl
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();

        public string TextAnnouncementTitle
        {
            get { return lblAnnouncementTitle.Text; }
            set { lblAnnouncementTitle.Text = value; }
        }
        public ucAnnouncement()
        {
            InitializeComponent();
            AddVisualFont();
        }

        private void ucAnnouncement_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.announcementHover;
        }

        private void ucAnnouncement_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.announcement;
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
            lblAnnouncementTitle.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);
            lblhehe.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);


        }
    }
}
