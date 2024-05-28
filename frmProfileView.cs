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

namespace InfoConnect
{
    public partial class frmProfileView : Form
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();
        frmMain frmMain;

        int id;

        string firstName;
        string middleName;
        string lastName;
        string section;
        string aboutMe;
        string email;
        string dateCreated;
        Image event_img;

        public frmProfileView(frmMain formMain, int id)
        {
            InitializeComponent();
            AddVisualFont();
            frmMain = formMain;
            this.id = id;
            PopulateStrings(id);

        }

        public void PopulateStrings(int id)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";
            string query = @"SELECT u.user_id, u.user_email, up.user_first_name, up.user_middle_name, up.user_last_name, up.user_section, up.user_about_me, up.user_date_created, up.user_img 
                         FROM users u
                         JOIN users_profile up ON u.user_id = up.user_profile_id
                         WHERE u.user_id = @userId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
               /* try
                {*/
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader["user_email"].ToString();
                            firstName = reader["user_first_name"].ToString();
                            middleName = reader["user_middle_name"].ToString();
                            lastName = reader["user_last_name"].ToString();
                            section = reader["user_section"].ToString();
                            aboutMe = reader["user_about_me"].ToString();
                            dateCreated = reader["user_date_created"].ToString();
                                // Read the blob data and convert it to an image
                            byte[] event_img_bytes = (byte[])reader["user_img"];

                            if (event_img_bytes != null && event_img_bytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(event_img_bytes))
                                    {
                                        try
                                        {
                                            ms.Seek(0, SeekOrigin.Begin); // Reset stream position
                                            event_img = Image.FromStream(ms);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error loading image: " + ex.Message);
                                            // Handle the exception or log it as needed
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                    }
                /*}
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }*/
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfileEdit Profile = new frmProfileEdit(frmMain, id);
            Profile.Show();

        }

        

        private void frmProfileView_Load(object sender, EventArgs e)
        {
            string processedFullName = NameLengthBreak();
            lblFullName.Text = processedFullName;
            lblCourseSection.Text = section;
            aboutMe = (aboutMe == "") ? "Write something about yourself...":aboutMe;
            lblAboutMe.Text = aboutMe;
            lblAccountDateCreated.Text = dateCreated;
            lblEmail.Text = InsertNewlines(email, 46);
            if (event_img != null)
            {
                guna2CirclePictureBox1.Image = new Bitmap(event_img);
            } else
            {
                guna2CirclePictureBox1.Image = Properties.Resources.default_profile;

            }
        }

        private void frmProfileView_Deactivate(object sender, EventArgs e)
        {
            this.Close();//Close form when focus is gone
        }

        private string NameLengthBreak()
        {
            string name;
            string[] nameArray = {firstName, middleName, lastName };
            string fullName = $"{nameArray[0]} {nameArray[1]} {nameArray[2]}";
            // Split the full name into parts based on spaces
            if (fullName.Length <= 26)
            {
                lblCourseSection.Location = new Point(149, 90); //Adjust the section 
                return fullName;

            }
            else
            {   
                name = $"{nameArray[0]} {nameArray[1][0]}. {nameArray[2]}";
                if (fullName.Length >= 26)
                {
                    name = $"{nameArray[0]}\n{nameArray[1]} {nameArray[2]}";
                    lblCourseSection.Location = new Point(149, 110); //Adjust the section 
                }
            }
            return name;
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
            lblFullName.Font = new Font(privateFont.Families[0], 12, FontStyle.Regular);
            lblCourseSection.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAboutMe.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblEmail.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAccountDateCreated.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);

        }
    }
}
