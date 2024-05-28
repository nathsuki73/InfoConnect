using Guna.UI2.WinForms;
using InfoConnect.Menu_forms;
using MySql.Data.MySqlClient;
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
using static System.Collections.Specialized.BitVector32;

namespace InfoConnect
{
    public partial class frmDashboard : Form
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";


        object[] profileDetails;
        frmMain main;
        public frmDashboard(object[] profileDetails, frmMain main)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;
            AddVisualFont();
            timer1.Start();
            SetAdviserName();
            this.main = main;

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

            lblAnnouncementCount.Text = $"{CountAnnouncements()}";
            lblEventCount.Text = $"{CountEvents()}";
            lblSection.Text = $"- {profileDetails[5]}";

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
            lblAnnouncementCount.Font = new Font(privateFont.Families[0], 40, FontStyle.Regular);
            lblEventCount.Font = new Font(privateFont.Families[0], 40, FontStyle.Regular);
            lblSection.Font = new Font(privateFont.Families[0], 13, FontStyle.Regular);
            lblAdviser.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);

        }

        private void SetAdviserName()
        {

            string query = "SELECT * FROM users_profile WHERE user_section = @section AND user_account_type = 'Teacher'";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                {
                    // Add parameter for section
                    commandDatabase.Parameters.AddWithValue("@section", profileDetails[5]);

                    try
                    {
                        databaseConnection.Open();
                        using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string firstName = reader.GetString(reader.GetOrdinal("user_first_name"));
                                string middletName = reader.GetString(reader.GetOrdinal("user_middle_name"));
                                string lastName = reader.GetString(reader.GetOrdinal("user_last_name"));
                                lblAdviser.Text = $"{lastName}, {firstName} {middletName}";
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private int CountAnnouncements()
        {
            int rowCount = 0;
            string query = "SELECT COUNT(*) FROM announcements"; // Query to count rows

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                {
                    try
                    {
                        databaseConnection.Open();
                        rowCount = Convert.ToInt32(commandDatabase.ExecuteScalar()); // ExecuteScalar returns the count directly
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return rowCount;

        }

        private int CountEvents()
        {
            int rowCount = 0;
            string query = "SELECT COUNT(*) FROM events"; // Query to count rows

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                {
                    try
                    {
                        databaseConnection.Open();
                        rowCount = Convert.ToInt32(commandDatabase.ExecuteScalar()); // ExecuteScalar returns the count directly
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return rowCount;
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

        private void btnOpenAnnouncements_Click(object sender, EventArgs e)
        {
        }
    }
}
