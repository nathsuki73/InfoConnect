using Guna.UI2.WinForms;
using InfoConnect.Menu_forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace InfoConnect
{
    public class EventData
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public Image EventImage { get; set; }
        public string EventTime { get; set; }
        public string EventDate { get; set; }
    }

    public partial class ucEventView : UserControl
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=infoconnect";
        List<EventData> eventsList = new List<EventData>();

        frmEvents frmEvents;
        Panel panel;
        public ucEventView(frmEvents frmevent, Panel panel)
        {
            InitializeComponent();
            frmEvents = frmevent;
            this.panel = panel;
        }

        private void ucEventView_Load(object sender, EventArgs e)
        {
            

            string query = @"SELECT *
                         FROM events";


            // Create and open a connection to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int yPosition = 0;
                        int i = 0;
                        while (reader.Read())
                        {
                            int event_id = (int)reader["event_id"];
                            string event_title = reader["event_title"].ToString();
                            string event_description = reader["event_description"].ToString();
                            string time = reader["event_time"].ToString();
                            string date = reader["event_date"].ToString();

                            // Read the blob data and convert it to an image
                            byte[] event_img_bytes = (byte[])reader["event_img"];
                            Image event_img;
                            using (MemoryStream ms = new MemoryStream(event_img_bytes))
                            {
                                event_img = Image.FromStream(ms);
                            }

                            // Store the data in the EventData object
                            EventData eventData = new EventData()
                            {
                                EventId = event_id,
                                EventTitle = event_title,
                                EventDescription = event_description,
                                EventImage = event_img,
                                EventTime = time,
                                EventDate = date
                            };

                            // Add the event data to the list
                            eventsList.Add(eventData);

                            // Create the radio button
                            Guna2ImageRadioButton imageRadioButton = new Guna2ImageRadioButton()
                            {
                                Size = new Size(25, 25),
                                ImageSize = new Size(25, 25),
                                Image = Properties.Resources.eventButton,
                                Location = new System.Drawing.Point(0, yPosition),
                                Tag = i
                            };
                            imageRadioButton.CheckedState.ImageSize = new Size(25, 25);
                            imageRadioButton.HoverState.ImageSize = new Size(25, 25);
                            imageRadioButton.CheckedState.Image = Properties.Resources.eventButton_checked;
                            imageRadioButton.HoverState.Image = Properties.Resources.eventButton_hover;
                            imageRadioButton.CheckedChanged += RadioButton_CheckedChanged;

                           if (i == 0)
                            {
                                imageRadioButton.Checked = true;
                            }

                            this.Controls.Add(imageRadioButton);
                            yPosition += 35;
                            i++;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching student data: " + ex.Message);
                }
            }


        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Guna2ImageRadioButton imageRadioButton = sender as Guna2ImageRadioButton;

            if (imageRadioButton != null && imageRadioButton.Checked)
            {
                int index = (int)imageRadioButton.Tag;
                EventData selectedEvent = eventsList[index];
                // Now you can use selectedEvent to display the event details
                frmEventDetails eventDetails = new frmEventDetails(selectedEvent);
                eventDetails.TopLevel = false;
                eventDetails.Dock = DockStyle.Fill;
                panel.Controls.Add(eventDetails);
                panel.Tag = eventDetails;
                eventDetails.Show();
            }


            

        }
    }
}
