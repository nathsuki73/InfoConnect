using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmLogin : Form
    {

        string connectionString = "datasource=192.168.1.18;port=3306;username=root;password=;database=infoconnect";

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
                    while (reader.Read())
                    {
                        this.Hide();
                        this.frmfrontpage.Hide();
                        frmMain frmMain = new frmMain();
                        frmMain.Show();
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
