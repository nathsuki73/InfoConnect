using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InfoConnect.Menu_forms
{
    public partial class frmSection : Form
    {
        int id;
        string section;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";

        public frmSection(object[] profileDetails)
        {
            InitializeComponent();
            id =Convert.ToInt32(profileDetails[0]);
            section = profileDetails[5].ToString();
            Console.WriteLine(section);
            Console.WriteLine(id);
            ucAccountDisplay1.TextAccountType = "Adviser";
            ucAccountDisplay1.TextFirstName = GetTeacherNameInSection();
            
            
        }

        
        private string GetTeacherNameInSection()
        {
            string query = @"SELECT user_first_name, user_middle_name, user_last_name
                    FROM users_profile
                    WHERE user_account_type = 'Teacher' AND user_section = @section";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@section", section);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["user_first_name"].ToString();
                            string middleName = reader["user_middle_name"].ToString();
                            string lastName = reader["user_last_name"].ToString();
                            return $"{firstName} {middleName} {lastName}";
                        }
                        else
                        {
                            return "This section currently have no adviser.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return "Error retrieving teacher name.";
                }
            }
        }

        private Dictionary<int, string> GetArrayOfStudents()
        {

            // Initialize the dictionary to hold student data
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Define the query
            string query = @"SELECT user_profile_id, user_first_name, user_middle_name, user_last_name
                         FROM users_profile
                         WHERE user_account_type = 'Student' AND user_section = @section";


            // Create and open a connection to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@section", section);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = $"{reader["user_first_name"]} {reader["user_middle_name"]} {reader["user_last_name"]}";
                            int id = (int)reader["user_profile_id"];
                            students.Add(id, fullName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching student data: " + ex.Message);
                }
            }

            return students;
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> students = GetArrayOfStudents();
            frmStudents formStudents = new frmStudents(students);
            formStudents.TopLevel = false;
            formStudents.Dock = DockStyle.Fill;
            this.frmPanel.Controls.Add(formStudents);
            this.frmPanel.Tag = formStudents;
            formStudents.Show();
        }
    }
}
