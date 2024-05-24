using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InfoConnect
{
    public partial class frmLogin : Form
    {

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        private frmFrontPage frmfrontpage;
        public frmLogin(frmFrontPage frmFrontPage)
        {
            InitializeComponent();
            this.frmfrontpage = frmFrontPage;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FixDesign();
            frmfrontpage.Enabled = false;

        }
        private void FixDesign()
        {
            //para maging transparent background nung textbox
            txtEmail.Parent = guna2PictureBox1;
            txtPassword.Parent = guna2PictureBox1;
            chckbxPassword.Parent = guna2PictureBox1;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE user_email=@email AND user_password=@password";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            commandDatabase.Parameters.AddWithValue("@email", txtEmail.Text);
            commandDatabase.Parameters.AddWithValue("@password", txtPassword.Text);
            MySqlDataReader reader;

            try
            {

                
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    int userId = -1; //default value
                    string email = String.Empty;
                    string password = String.Empty;
                    while (reader.Read())
                    {
                        // Retrieve the 'id' column value from the reader
                        userId = reader.GetInt32(reader.GetOrdinal("user_id"));
                        email = reader.GetString(reader.GetOrdinal("user_email"));
                        password = reader.GetString(reader.GetOrdinal("user_password"));
                    }
                    reader.Close();

                    if (userId != -1)
                    {
                        // Query the users_profile table using the retrieved userId
                        string profileQuery = "SELECT * FROM users_profile WHERE user_profile_id=@UserId";
                        MySqlCommand profileCommand = new MySqlCommand(profileQuery, databaseConnection);
                        profileCommand.Parameters.AddWithValue("@UserId", userId);
                        MySqlDataReader profileReader = profileCommand.ExecuteReader();
                        if (profileReader.HasRows)
                        {
                            profileReader.Read();
                            object[] profileDetails = new object[profileReader.FieldCount + 2];

                            // Get the values of the current row and store them in the array
                            profileReader.GetValues(profileDetails);
                            // Add email and password to the profileDetails array
                            profileDetails[profileReader.FieldCount] = email;
                            profileDetails[profileReader.FieldCount + 1] = password;
                            // Hide the current forms
                            this.Hide();
                            this.frmfrontpage.Hide();
                            
                            // Pass the userId (or any other data you retrieved) to the frmMain constructor and show the form
                            frmMain frmMain = new frmMain(profileDetails);
                            
                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("No profile found for this user.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                // It's generally not recommended to throw exceptions in UI applications unless you have a specific reason to do so.
            }
            finally
            {
                // Always close the database connection after use to release resources.
                databaseConnection.Close();
            }
        }

        private void chckbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmfrontpage.Enabled = true;
        }
    }
}
