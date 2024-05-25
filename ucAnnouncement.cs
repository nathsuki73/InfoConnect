using MySql.Data.MySqlClient;
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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InfoConnect
{
    public partial class ucAnnouncement : UserControl
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        PrivateFontCollection privateFont = new PrivateFontCollection();

        public string TextAnnouncementTitle
        {
            get { return lblAnnouncementTitle.Text; }
            set { lblAnnouncementTitle.Text = value; }
        }

        public string TextDate
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public string TextTime
        {
            get { return lblTime.Text; }
            set { lblTime.Text = value; }
        }

        int id;
        public ucAnnouncement(int announcementId)
        {
            InitializeComponent();
            id = announcementId;
            AddVisualFont();
        }

        private void ControlHover()
        {
            this.BackgroundImage = Properties.Resources.announcementHover;
            lblhehe.ForeColor = Color.White;
        }

        private void ControlLeave()
        {
            this.BackgroundImage = Properties.Resources.announcement;
            lblhehe.ForeColor = Color.Black;
        }
        private void ucAnnouncement_MouseHover(object sender, EventArgs e)
        {
            ControlHover();
        }

        private void ucAnnouncement_MouseLeave(object sender, EventArgs e)
        {
            ControlLeave();
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

        private void openAnnouncementDetails()
        {
            string query = @"SELECT *
                         FROM announcements
                         WHERE announcement_id = @Id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            frmannouncementDetails announcementdetails = new frmannouncementDetails(id);
                            announcementdetails.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ucAnnouncement_Click(object sender, EventArgs e)
        {
            openAnnouncementDetails();
        }

        private void lblhehe_Click(object sender, EventArgs e)
        {
            openAnnouncementDetails();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            openAnnouncementDetails();

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            openAnnouncementDetails();

        }

        private void lblhehe_MouseHover(object sender, EventArgs e)
        {
            ControlHover();
        }

        private void lblAnnouncementTitle_MouseHover(object sender, EventArgs e)
        {
            ControlHover();
        }

        private void lblTime_MouseHover(object sender, EventArgs e)
        {
            ControlHover();
        }

        private void lblDate_MouseHover(object sender, EventArgs e)
        {
            ControlHover();
        }

        private void lblAnnouncementTitle_MouseLeave(object sender, EventArgs e)
        {
            ControlLeave();
        }

        private void lblhehe_MouseLeave(object sender, EventArgs e)
        {
            ControlLeave();
        }

        private void lblTime_MouseLeave(object sender, EventArgs e)
        {
            ControlLeave();
        }

        private void lblDate_MouseLeave(object sender, EventArgs e)
        {
            ControlLeave();
        }
    }
}
