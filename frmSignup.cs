using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace InfoConnect
{
    public partial class frmSignup : Form
    {
        string connectionString = "datasource=192.168.1.18;port=3306;username=root;password=;database=infoconnect";

        private ucSignupPageOne page1;
        private ucSignupPageTwo page2;

        
        

        string firstName;
        string middleName;
        string lastName;
        string email;
        string contact;
        string emergencyContact;

        string sex;
        int month;
        string day;
        string year;

        DateTime dateBirth; // month day year will be converted to date of birth here in validation method;
        string password;
        string confirmPassword;

        public frmSignup()
        {
            InitializeComponent();
            pnlSignup.Parent = pictureBoxSignUp;
            page1 = new ucSignupPageOne();
            page2 = new ucSignupPageTwo();
            ShowPageOne();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            rbtnPageOne.Checked = true;
        }


        private void rbtnPageOne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPageOne.Checked == true)
            {
                ShowPageOne();
                btnBack.Visible = false;
                btnSignUp.Visible = false;
                btnNext.Visible = true;
            }
            else
            {
                ShowPageTwo();
                btnBack.Visible = true;
                btnSignUp.Visible = true;
                btnNext.Visible = false;
            }
        }

        private void ShowPageOne()
        {
            PopulateDetails();
            pnlSignup.Controls.Clear(); // Clear any existing controls
            pnlSignup.Controls.Add(page1);
        }

        private void ShowPageTwo()
        {
            PopulateDetails();
            pnlSignup.Controls.Clear(); // Clear any existing controls
            pnlSignup.Controls.Add(page2);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            rbtnPageOne.Checked = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rbtnPageTwo.Checked = true;
        }

        private void PopulateDetails()
        {
            // Assuming the textboxes for email and password are directly on ucSignupPageOne
            ucSignupPageOne ucPageOne = pnlSignup.Controls.OfType<ucSignupPageOne>().FirstOrDefault();
            if (ucPageOne != null)
            {
                firstName = ucPageOne.TextFirstName;
                middleName = ucPageOne.TextMiddleName;
                lastName = ucPageOne.TextLastName;
                email = ucPageOne.TextEmail;
                contact = ucPageOne.TextContactNumber;
                emergencyContact = ucPageOne.TextEmergencyContactNumber;
            }

            // Assuming the textboxes for first name, middle name, and last name are directly on ucSignupPageTwo
            ucSignupPageTwo ucPageTwo = pnlSignup.Controls.OfType<ucSignupPageTwo>().FirstOrDefault();
            if (ucPageTwo != null)
            {
                sex = ucPageTwo.TextSex;
                // date here
                month = ucPageTwo.TextMonth;
                day = ucPageTwo.TextDay;
                year = ucPageTwo.TextYear;

                password = ucPageTwo.TextPassword;
                confirmPassword = ucPageTwo.TextConfirmPassword;

            }
        }


        // TODO: update this validation
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(firstName) 
                || string.IsNullOrWhiteSpace(middleName) 
                || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrEmpty(contact)
                || string.IsNullOrEmpty(emergencyContact))
            {
                MessageBox.Show("Name cannot be null or empty.");
                return false;
            }

            if (sex == "Sex")
            {
                MessageBox.Show("Please choose your gender.");
                return false;
            }

            if (day != "Day" && month != 0 && year != "Year")
            {
                dateBirth = new DateTime(int.Parse(year), month, int.Parse(day));
            }
            else
            {
                MessageBox.Show("Please choose your birthday.");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password don't match.");
                return false;
            }

            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            PopulateDetails();

            if (!ValidateInputs())
            {
                return;
            }

            // Define the queries to insert a new user and a new user profile into the database.
            string insertUserQuery = "INSERT INTO users (user_email, user_password) VALUES (@Email, @Password);";
            string insertUserProfileQuery = "INSERT INTO users_profile (user_first_name, user_middle_name, user_last_name, user_sex, user_birth_date, user_contact)" +
                                                              " VALUES (@FirstName, @MiddleName, @LastName, @Sex, @DateBirth, @Contact);";

            // Create a new MySqlConnection object using the provided connection string.
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            // Create MySqlCommand objects for each query.
            MySqlCommand commandInsertUser = new MySqlCommand(insertUserQuery, databaseConnection);
            MySqlCommand commandInsertUserProfile = new MySqlCommand(insertUserProfileQuery, databaseConnection);

            // Add parameters to the user command and assign values to them.
            commandInsertUser.Parameters.AddWithValue("@Email", email);
            commandInsertUser.Parameters.AddWithValue("@Password", password);

            // Add parameters to the user profile command. The UserId parameter will be set after the user is inserted.
            commandInsertUserProfile.Parameters.AddWithValue("@FirstName", firstName);
            commandInsertUserProfile.Parameters.AddWithValue("@MiddleName", middleName);
            commandInsertUserProfile.Parameters.AddWithValue("@LastName", lastName);

            commandInsertUserProfile.Parameters.AddWithValue("@Contact", contact);
            commandInsertUserProfile.Parameters.AddWithValue("@Sex", sex);
            commandInsertUserProfile.Parameters.AddWithValue("@DateBirth", dateBirth);


            commandInsertUser.ExecuteNonQuery();
            commandInsertUserProfile.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Success");
            
        }
    }
}
