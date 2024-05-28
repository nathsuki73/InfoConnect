using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Collections.Specialized.BitVector32;
using System.Globalization;

namespace InfoConnect
{
    public partial class frmProfileEdit : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        PrivateFontCollection privateFont = new PrivateFontCollection();
        private frmProfileEditInfo newInfo;

        frmMain formMain;
        object[] profileDetails;

        int id;

        string email;
        string firstName;
        string middleName;
        string lastName;
        string accountType;
        string sex;
        DateTime birthDate;
        string contact;
        string address;
        string aboutMe;
        string dateCreated;

        

        private bool isNewFormOpen = false;
        public frmProfileEdit(frmMain frmMain, int id)
        {
            InitializeComponent();
            formMain = frmMain;
            this.id = id;
            formMain.Enabled = false;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            AddVisualFont();
            PopulateString();
            PopulateLabel();
           
        }

        private void PopulateString()
        {
            string query = @"SELECT u.user_id, u.user_email, up.user_first_name, up.user_middle_name, up.user_last_name, up.user_account_type, up.user_sex, up.user_birth_date, up.user_contact, up.user_address, up.user_about_me, up.user_date_created 
                         FROM users u
                         JOIN users_profile up ON u.user_id = up.user_profile_id
                         WHERE u.user_id = @userId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
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
                            accountType = reader["user_account_type"].ToString();

                            sex = reader["user_sex"].ToString();
                            birthDate = Convert.ToDateTime(reader["user_birth_date"]);
                            contact = reader["user_contact"].ToString();
                            address = reader["user_address"].ToString();
                            accountType = reader["user_account_type"].ToString();

                            aboutMe = reader["user_about_me"].ToString();
                            dateCreated = reader["user_date_created"].ToString();
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
        private void PopulateLabel()
        {
            // putting the name in label
            lblFirstName.Text = firstName;
            lblMiddleName.Text = middleName;
            lblLastName.Text = lastName;
            
            

            // putting sex
            lblSex.Text = sex;
            //Date of birth
            lblBirthDate.Text = ((DateTime)birthDate).ToString("yyyy-MM-dd");
            //Account type
            lblAccountType.Text = accountType;
            //Email 
            lblEmail.Text = email;
            //Contact
            lblContact.Text = (contact == "") ? "09XXXXXXXXX" : contact;
            //address
            lblAddress.Text = (address == "") ? "Provide your address here..." : address;
            //about me
            string tempAboutme = (aboutMe == "") ? "Write about yourself...": aboutMe;
            lblAboutMe.Text = tempAboutme;
            lblAboutMeCount.Text = (aboutMe == "") ? "0/184":$"{lblAboutMe.Text.Length}";

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
            Font customFont = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            Font aboutMeCountFont = new Font(privateFont.Families[0], 8, FontStyle.Regular);
            Font aboutMeFont = new Font(privateFont.Families[0], 9, FontStyle.Regular);


            Label[] labels = { lblLastName, lblFirstName, lblMiddleName, lblSex, lblBirthDate, lblAccountType, lblPassword, lblEmail, lblContact, lblAddress };

            foreach (Label lbl in labels)
            {
                lbl.Font = customFont;
            }
            lblAboutMeCount.Font = aboutMeCountFont;
            lblAboutMe.Font = aboutMeFont;

            foreach (Label label in labels)
            {
                label.Parent = guna2PictureBox1;
            }
            lblAboutMeCount.Parent = guna2PictureBox1;
            lblAboutMe.Parent = guna2PictureBox1;


        }



        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private string ShowFormEditor(Guna2PictureBox image, string id)
        {
            string newData = null;
            
            newInfo = new frmProfileEditInfo(image.Size, image.Image, id, this);
            newInfo.ShowDialog();
            // Retrieve the return value from the child form before closing it
            newData = newInfo.ReturnValue;
            newInfo.Close();

            
            return newData;
        }

        private void btnEditLastName_Click(object sender, EventArgs e)
        {
            lblLastName.Text = ShowFormEditor(pcbLastName, "Last Name");
            this.Refresh();
        }

        private void btnEditFirstName_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = ShowFormEditor(pcbFirstName, "First Name");
            this.Refresh();

        }

        private void btnEditMiddleName_Click(object sender, EventArgs e)
        {
            lblMiddleName.Text = ShowFormEditor(pcbMiddleName, "Middle Name");
            this.Refresh();

        }

        private void btnEditSex_Click(object sender, EventArgs e)
        {
            lblSex.Text = ShowFormEditor(pcbSex, "Sex");
            this.Refresh();

        }



        private void btnEditAccountType_Click(object sender, EventArgs e)
        {
            lblAccountType.Text = ShowFormEditor(pcbAccountType, "Account Type");
            this.Refresh();

        }

        private void btnEditBirthDate_Click(object sender, EventArgs e)
        {
            lblBirthDate.Text = ShowFormEditor(pcbBirthDate, "Birth Date");
            this.Refresh();

        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            lblEmail.Text = ShowFormEditor(pcbEmail, "Email");
            this.Refresh();

        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            string contact = ShowFormEditor(pcbContact, "Contact");
            
            lblContact.Text = contact.Substring(0, 11); // Truncate if longer
            
            this.Refresh();

        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            lblAddress.Text = ShowFormEditor(pcbAddress, "Address");
            this.Refresh();

        }

        private void btnEditAboutMe_Click(object sender, EventArgs e)
        {
            string temp = ShowFormEditor(pcbAboutMe, "About Me");
            lblAboutMe.Text = InsertNewlines(temp, 46);

            this.Refresh();

        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbPassword, "Password");
            this.Refresh();

        }

        private void frmProfileEdit_Deactivate(object sender, EventArgs e)
        {

        }

        private void frmProfileEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProfileView frmProfileView = new frmProfileView(formMain, id);
            formMain.Enabled = true;
            frmProfileView.Show();
        }

        // Method to update the label text
        




        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (!ChangesValidated())
            {
                return;
            }
            string updateQuery = @"UPDATE users u
                               JOIN users_profile up ON u.user_id = up.user_profile_id
                               SET u.user_email = @userEmail,
                                   up.user_first_name = @userFirstName,
                                   up.user_middle_name = @userMiddleName,
                                   up.user_last_name = @userLastName,
                                   up.user_account_type = @userAccountType,
                                   up.user_sex = @userSex,
                                   up.user_birth_date = @userBirthDate,
                                   up.user_contact = @userContact,
                                   up.user_address = @userAddress,
                                   up.user_about_me = @userAboutMe
                               WHERE u.user_id = @userId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@userEmail", lblEmail.Text);
                    cmd.Parameters.AddWithValue("@userFirstName", lblFirstName.Text);
                    cmd.Parameters.AddWithValue("@userMiddleName", lblMiddleName.Text);
                    cmd.Parameters.AddWithValue("@userLastName", lblLastName.Text);
                    cmd.Parameters.AddWithValue("@userAccountType", lblAccountType.Text);
                    cmd.Parameters.AddWithValue("@userSex", lblSex.Text);
                    cmd.Parameters.AddWithValue("@userBirthDate", lblBirthDate.Text);
                    cmd.Parameters.AddWithValue("@userContact", lblContact.Text);
                    cmd.Parameters.AddWithValue("@userAddress", lblAddress.Text);
                    cmd.Parameters.AddWithValue("@userAboutMe", lblAboutMe.Text);
                    cmd.Parameters.AddWithValue("@userId", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. User not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            this.Close();
        }

        private bool ChangesValidated()
        {
            DateTime tempBirthday;

            if (lblFirstName.Text.Length >= 50 || lblMiddleName.Text.Length >= 50 || lblLastName.Text.Length >= 50)
            {
                MessageBox.Show("Names should be less than 50 characters each.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lblFirstName.Text) || string.IsNullOrWhiteSpace(lblMiddleName.Text) || string.IsNullOrWhiteSpace(lblLastName.Text))
            {
                MessageBox.Show("First Name, Middle Name, and Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lblAccountType.Text))
            {
                MessageBox.Show("Account Type cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lblSex.Text))
            {
                MessageBox.Show("Sex cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (DateTime.TryParse(lblBirthDate.Text, out tempBirthday))
            {
                if (tempBirthday > DateTime.Now)
                {
                    MessageBox.Show("Birth date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tempBirthday < DateTime.Now.AddYears(-120))
                {
                    MessageBox.Show("Birth date is too far in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (string.IsNullOrWhiteSpace(lblContact.Text))
            {
                MessageBox.Show("Contact cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!lblContact.Text.StartsWith("09"))
            {
                MessageBox.Show("Contact should start with '09'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (lblContact.Text.Length > 11)
            {
                MessageBox.Show("Contact should be 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ToTitleCase(lblFirstName.Text);
            ToTitleCase(lblMiddleName.Text);
            ToTitleCase(lblLastName.Text);
            return true;

        }
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
