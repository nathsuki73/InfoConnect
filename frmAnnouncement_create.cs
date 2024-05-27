using InfoConnect.Info_Forms;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InfoConnect
{
    public partial class frmAnnouncement_create : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        // Define the path to the font file
        string fontFilePathNath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
        string fontFilePathGio = "C:\\Users\\gioan\\OneDrive\\Pictures\\InfoConnect\\share-tech-mono\\ShareTechMono-Regular.ttf";

        PrivateFontCollection privateFont = new PrivateFontCollection();

        string name;
        string section;
        public frmAnnouncement_create(string name, string section)
        {
            InitializeComponent();
            this.name = name;
            this.section = section;
        }

        private void frmAnnouncement_create_Load(object sender, EventArgs e)
        {
            AddVisualFont();
            txtTitle.MaxLength = 60;
            txtDescription.MaxLength = 500;
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
            txtTitle.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtDescription.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = $"{txtTitle.Text.Length}/60";

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = $"{txtDescription.Text.Length}/500";

        }

        private void btnUploadAnnouncement_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }


            // Define the query to insert a new announcement into the database.
            string insertAnnouncementQuery = "INSERT INTO announcements (announcement_section, announcement_title, announcement_content, announcement_dateTime, announcement_CreatedBy) " +
                                             "VALUES (@Section, @Title, @Content, @DateTime, @CreatedBy)";

            // Use a using statement to ensure the connection is properly closed and disposed of.
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection.
                    databaseConnection.Open();

                    // Create the MySqlCommand object for the query.
                    MySqlCommand commandInsertAnnouncement = new MySqlCommand(insertAnnouncementQuery, databaseConnection);

                    // Add parameters to the command and assign values to them.
                    commandInsertAnnouncement.Parameters.AddWithValue("@Section", section);
                    commandInsertAnnouncement.Parameters.AddWithValue("@Title", txtTitle.Text); // Assuming there's a txtTitle textbox for the title
                    commandInsertAnnouncement.Parameters.AddWithValue("@Content", txtDescription.Text);
                    commandInsertAnnouncement.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    commandInsertAnnouncement.Parameters.AddWithValue("@CreatedBy", name);

                    // Execute the query.
                    commandInsertAnnouncement.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the execution.
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close the connection in the finally block to ensure it gets closed even if an exception occurs.
                    if (databaseConnection.State == System.Data.ConnectionState.Open)
                    {
                        databaseConnection.Close();
                    }
                }
            }

            // Show success message and close the form.
            announcementUpload uploadedAnnouncement = new announcementUpload();
            uploadedAnnouncement.ShowDialog();
            this.Close();

        }
    }
}
