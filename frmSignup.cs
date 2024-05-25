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
using InfoConnect.Error_Forms;
using System.Globalization;
using InfoConnect.Info_Forms;

namespace InfoConnect
{
    public partial class frmSignup : Form
    {
        private frmFrontPage frmfrontpage;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        private ucSignupPageOne page1;
        private ucSignupPageTwo page2;




        string firstName;
        string middleName;
        string lastName;
        string email;
        string accountType;
        string section;

        string sex;
        int month;
        string day;
        string year;

        DateTime dateBirth; // month day year will be converted to date of birth here in validation method;
        string password;
        string confirmPassword;

        DateTime dateCreated;

        public frmSignup(frmFrontPage frmFrontPage)
        {
            InitializeComponent();
            pnlSignup.Parent = pictureBoxSignUp;
            page1 = new ucSignupPageOne();
            page2 = new ucSignupPageTwo();
            ShowPageOne();
            this.frmfrontpage = frmFrontPage;
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            rbtnPageOne.Checked = true;
            frmfrontpage.Enabled = false;
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
                accountType = ucPageOne.TextAccountType;
                section = ucPageOne.TextSection;
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
            string firstname = firstName.Trim();
            string middlename = middleName.Trim();
            string lastname = lastName.Trim();
            string passWord = password.Trim();

            if (string.IsNullOrWhiteSpace(firstName)
                || string.IsNullOrWhiteSpace(middleName)
                || string.IsNullOrWhiteSpace(lastName))
            {
                emptyName emptyNameError = new emptyName();
                emptyNameError.ShowDialog();
                return false;
            }

            if (firstname.Any(char.IsDigit) || firstname.Any(char.IsSymbol)
                 || middlename.Any(char.IsDigit) || middlename.Any(char.IsSymbol)
                 || lastname.Any(char.IsDigit) || lastname.Any(char.IsSymbol))
            {
                digitSymbol digitSymbolError = new digitSymbol();
                digitSymbolError.ShowDialog();
                return false;
            }

            if (accountType == "Account Type" || section == "Section" || sex == "Sex")
            {
                DropDown dropDownItemsError = new DropDown();
                dropDownItemsError.ShowDialog();
                return false;
            }

            if (!email.EndsWith("@lspu.edu.ph", StringComparison.Ordinal))
            {
                emailError emailerror = new emailError();
                emailerror.ShowDialog();
                return false;
            }

            if (day != "Day" && month != 0 && year != "Year")
            {
                try
                {
                    dateBirth = new DateTime(int.Parse(year), month, int.Parse(day));
                }
                catch (FormatException)
                {
                    birthdateError birthdateerror = new birthdateError();
                    birthdateerror.ShowDialog();
                    return false;
                }
            }
            else
            {
                selectBirthday birthdayError = new selectBirthday();
                birthdayError.ShowDialog();
                return false;
            }

            if (string.IsNullOrWhiteSpace(passWord))
            {
                emptyPassword emptyPass = new emptyPassword();
                emptyPass.ShowDialog();
                return false;
            }
            if (password != confirmPassword)
            {
                PasswordMatch wrongPassword = new PasswordMatch();
                wrongPassword.ShowDialog();
                return false;
            }

            return true;
        }

        private bool EmailAlreadyExist()
        {
            string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE user_email = @Email";
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                databaseConnection.Open();
                using (MySqlCommand commandCheckEmail = new MySqlCommand(checkEmailQuery, databaseConnection))
                {
                    commandCheckEmail.Parameters.AddWithValue("@Email", email);
                    int emailCount = Convert.ToInt32(commandCheckEmail.ExecuteScalar());
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Email Already exist.");
                        return true;
                    }
                    return false;

                }
            }
        }

        private bool TeacherAlreadyExists()
        {
            string checkEmailQuery = "SELECT COUNT(*) FROM users_profile WHERE user_account_type = @AccountType AND user_section = @Section";
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                databaseConnection.Open();
                using (MySqlCommand commandCheckEmail = new MySqlCommand(checkEmailQuery, databaseConnection))
                {
                    commandCheckEmail.Parameters.AddWithValue("@AccountType", accountType);
                    commandCheckEmail.Parameters.AddWithValue("@Section", section);

                    int account = Convert.ToInt32(commandCheckEmail.ExecuteScalar());
                    if (account > 0 && accountType == "Teacher")
                    {
                        MessageBox.Show("There is already assigned teacher in this section.");
                        return true;
                    }
                    return false;

                }
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            PopulateDetails();

            if (!ValidateInputs())
            {
                return;
            }

            if (EmailAlreadyExist())
            {
                return;
            }

            if (TeacherAlreadyExists())
            {
                return;
            }

            // Define the queries to insert a new user and a new user profile into the database.
            string insertUserQuery = "INSERT INTO users (user_email, user_password) VALUES (@Email, @Password);";
            string insertUserProfileQuery = "INSERT INTO users_profile (user_first_name, user_middle_name, user_last_name, user_account_type, user_section, user_sex, user_birth_date, user_date_created)" +
                                                              " VALUES (@FirstName, @MiddleName, @LastName, @AccountType, @Section, @Sex, @DateBirth, @DateCreated);";

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
            commandInsertUserProfile.Parameters.AddWithValue("@AccountType", accountType);
            commandInsertUserProfile.Parameters.AddWithValue("@Section", section);

            commandInsertUserProfile.Parameters.AddWithValue("@Sex", sex);
            commandInsertUserProfile.Parameters.AddWithValue("@DateBirth", dateBirth);
            commandInsertUserProfile.Parameters.AddWithValue("@DateCreated", DateTime.Now);



            commandInsertUser.ExecuteNonQuery();
            commandInsertUserProfile.ExecuteNonQuery();
            databaseConnection.Close();
            accountCreated createSuccessfully = new accountCreated();
            createSuccessfully.ShowDialog();
            this.Close();
            
        }

        private void frmSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmfrontpage.Enabled = true;
        }
    }
}
