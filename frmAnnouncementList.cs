using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace InfoConnect
{
    public partial class frmAnnouncementList : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";
        string section;
        public frmAnnouncementList(string section)
        {
            InitializeComponent();
            this.section = section;
        }

        private void frmAnnouncementList_Load(object sender, EventArgs e)
        {
            // Define the query
            string query = @"SELECT *
                         FROM announcements
                         WHERE announcement_section = @section";


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
                        int newPoint = 0;
                        Point location = new Point(0, newPoint);
                        while (reader.Read())
                        {
                            int id = (int)reader["announcement_id"];
                            string title = reader["announcement_title"].ToString();
                            DateTime date = (DateTime)reader["announcement_dateTime"];

                            ucAnnouncement ucAnnouncementOne = new ucAnnouncement(id);
                            ucAnnouncementOne.TextAnnouncementTitle = title;
                            ucAnnouncementOne.TextDate = date.ToString("yyyy-MM-dd");
                            ucAnnouncementOne.TextTime = date.ToString("HH:mm:ss");
                            ucAnnouncementOne.Location = location;
                            this.Controls.Add(ucAnnouncementOne);
                            newPoint = newPoint + 85;
                            location = new Point(0, newPoint);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching student data: " + ex.Message);
                }
            }
        }

       
    }
}
