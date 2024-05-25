using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        private void frmSection_Load(object sender, EventArgs e)
        {
            
        }
    }
}
