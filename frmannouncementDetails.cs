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

namespace InfoConnect
{
    public partial class frmannouncementDetails : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";
        PrivateFontCollection privateFont = new PrivateFontCollection();

        int id;
        public frmannouncementDetails(int announcementId)
        {
            InitializeComponent();
            id = announcementId;
        }

        private void frmannouncementDetails_Load(object sender, EventArgs e)
        {
            // Define the query
            string query = @"SELECT *
                         FROM announcements
                         WHERE announcement_id = @Id";


            // Create and open a connection to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            int id = (int)reader["announcement_id"];
                            lblTitle.Text = reader["announcement_title"].ToString();
                            string content = reader["announcement_content"].ToString();
                            lblDescription.Text = InsertNewlines(content, 50);
                            lblCreatedBy.Text = $"Created By: {reader["announcement_CreatedBy"].ToString()}";
                            DateTime date = (DateTime)reader["announcement_dateTime"];
                            lblTime.Text = $"{date.ToString("yyyy-MM-dd")}"; 
                            lblDate.Text = $"{date.ToString("HH:mm:ss")}";


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching student data: " + ex.Message);
                }

                AddVisualFont();
            }

            
        }

        public static string InsertNewlines(string text, int lineLength)
        {
            StringBuilder result = new StringBuilder();
            while (text.Length > lineLength)
            {
                result.AppendLine(text.Substring(0, lineLength));
                text = text.Substring(lineLength);
            }
            result.Append(text); // add any remaining text
            return result.ToString();
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
            lblTitle.Font = new Font(privateFont.Families[0], 13, FontStyle.Regular);
            lblDescription.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);
            lblDate.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);
            lblTime.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);
            lblCreatedBy.Font = new Font(privateFont.Families[0], 11, FontStyle.Regular);

        }
    }
}
