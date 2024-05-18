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

namespace InfoConnect
{
    public partial class frmSignup : Form
    {
        string connectionString = "datasource=192.168.1.13;port=3306;username=root;password=;database=infoconnect";

        private ucSignupPageOne page1;
        private ucSignupPageTwo page2;

        string email;
        string password;
        string firstName;
        string middleName;
        string lastName;

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
            }

            // Assuming the textboxes for first name, middle name, and last name are directly on ucSignupPageTwo
            ucSignupPageTwo ucPageTwo = pnlSignup.Controls.OfType<ucSignupPageTwo>().FirstOrDefault();
            if (ucPageTwo != null)
            {

                password = ucPageTwo.TextPassword;

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            PopulateDetails();
            
            // Define the queries to insert a new user and a new user profile into the database.
            string insertUserQuery = "INSERT INTO users (user_email, user_password) VALUES (@Email, @Password);";
            string insertUserProfileQuery = "INSERT INTO users_profile (user_first_name, user_middle_name, user_last_name) VALUES (@FirstName, @MiddleName, @LastName);";

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

            commandInsertUser.ExecuteNonQuery();
            commandInsertUserProfile.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Success");
            
            

            

        }
    }
}
