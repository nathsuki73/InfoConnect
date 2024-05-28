using Guna.UI2.WinForms;
using InfoConnect.Menu_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmDashboard : Form
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();

        object[] profileDetails;
        public frmDashboard(object[] profileDetails)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;
            AddVisualFont();
            timer1.Start();

        }


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
            frmAnnouncements announcements = new frmAnnouncements(profileDetails);
            announcements.TopLevel = false;
            announcements.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(announcements);
            this.panel1.Tag = announcements;
            announcements.Show();

            frmEvents events = new frmEvents();
            events.TopLevel = false;
            events.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(events);
            this.panel2.Tag = events;
            events.Show();
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
            lblGreet.Font = new Font(privateFont.Families[0], 30, FontStyle.Regular);
            lblRealTime.Font = new Font(privateFont.Families[0], 40, FontStyle.Regular);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRealTime.Text = DateTime.Now.ToString("HH:mm tt");

            string greet;
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                greet = "Morning";
            }
            else if (hour < 17)
            {
                greet  = "Afternoon";
            }
            else
            {
                greet = "Evening";
            }

            lblGreet.Text = $"Good {greet}!, {profileDetails[1]} \n\tyou currently have:";
        }
    }
}
