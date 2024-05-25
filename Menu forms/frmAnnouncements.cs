using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect.Menu_forms
{
    public partial class frmAnnouncements : Form
    {
        object[] profileDetails;

        string name;
        string section;

        
        public frmAnnouncements(object[] profileDetails)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;
            string firstname = profileDetails[1].ToString();
            string middlename = profileDetails[2].ToString();
            string lastname = profileDetails[3].ToString();
            name = $"{lastname}, {firstname} {middlename}"; 
            section = profileDetails[5].ToString();


        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            if (!(profileDetails[4].ToString() == "Teacher"))
            {
                MessageBox.Show("You need teacher Permissions to create announcements.");
                return;
            }

            //ShowForm for create announcement
            frmAnnouncement_create announcementCreate = new frmAnnouncement_create(name, section);
            announcementCreate.ShowDialog();
        }

        private void frmAnnouncements_Load(object sender, EventArgs e)
        {

            frmAnnouncementList formAnnouncements = new frmAnnouncementList(section);
            formAnnouncements.TopLevel = false;
            formAnnouncements.Dock = DockStyle.Fill;
            this.frmPanel.Controls.Add(formAnnouncements);
            this.frmPanel.Tag = formAnnouncements;
            formAnnouncements.Show();
        }
    }
}
