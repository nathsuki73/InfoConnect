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
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace InfoConnect
{
    public partial class frmEvents_create : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";


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

        private void btnUploadEvent_Click(object sender, EventArgs e)
        {
            emptyTitle noTitle = new emptyTitle();
            if (txtTitleEvent.Text == "")
            {
                noTitle.ShowDialog();
                return;
            }
            if (txtDescriptionEvent.Text == "")
            {
                noTitle.ShowDialog();
                return;
            }

            // Define the query to insert a new announcement into the database.
            string insertAnnouncementQuery = "INSERT INTO events (event_title, event_description, event_date, event_time, event_img) " +
                                             "VALUES ( @Title, @Content, @Date ,@Time, @Image)";

            // Use a using statement to ensure the connection is properly closed and disposed of.
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                    // Open the connection.
                    databaseConnection.Open();

                    // Create the MySqlCommand object for the query.
                    MySqlCommand commandInsertAnnouncement = new MySqlCommand(insertAnnouncementQuery, databaseConnection);

                    // Add parameters to the command and assign values to them.
                    commandInsertAnnouncement.Parameters.AddWithValue("@Title", txtTitleEvent.Text); // Assuming there's a txtTitle textbox for the title
                    commandInsertAnnouncement.Parameters.AddWithValue("@Content", txtDescriptionEvent.Text);
                    commandInsertAnnouncement.Parameters.AddWithValue("@Date", txtDate.Text);
                    commandInsertAnnouncement.Parameters.AddWithValue("@Time", txtTime.Text);
                    byte[] imageBytes = GetImageBytesFromFile(txtImage.Text);

                    commandInsertAnnouncement.Parameters.AddWithValue("@Image", imageBytes);



                    // Execute the query.
                    commandInsertAnnouncement.ExecuteNonQuery();
               
            }

            // Show success message and close the form.
            eventUploaded eventuploaded = new eventUploaded();
            eventuploaded.ShowDialog();
            this.Close();
        }
        private static byte[] GetImageBytesFromFile(string imagePath)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    return br.ReadBytes((int)fs.Length);
                }
            }
        }
    }
}
