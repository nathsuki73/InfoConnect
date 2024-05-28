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
    public partial class frmEventDetails : Form
    {

        PrivateFontCollection privateFont = new PrivateFontCollection();
        EventData selectedEvent;

        public frmEventDetails(EventData selectedEvent)
        {
            InitializeComponent();
            AddVisualFont();
            this.selectedEvent = selectedEvent;


        }

        public void AddVisualFont()
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
            lblTitle.Font = new Font(privateFont.Families[0], 15, FontStyle.Regular);
            lblDescription.Font = new Font(privateFont.Families[0], 12, FontStyle.Regular);

        }

        private void frmEventDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = selectedEvent.EventTitle;
            lblDescription.Text = selectedEvent.EventDescription;
            pictureBox1.Image = selectedEvent.EventImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            frmEventsAdditionalDetails newDetails = new frmEventsAdditionalDetails(selectedEvent.EventTime, selectedEvent.EventDate);
            newDetails.Show();

        }
    }
}
