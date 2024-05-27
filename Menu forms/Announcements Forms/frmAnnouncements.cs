using InfoConnect.Info_Forms;
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
        string accountType;
        
        public frmAnnouncements(object[] profileDetails)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;
            string firstname = profileDetails[1].ToString();
            string middlename = profileDetails[2].ToString();
            string lastname = profileDetails[3].ToString();
            name = $"{lastname}, {firstname} {middlename}"; 
            section = profileDetails[5].ToString();
            accountType = profileDetails[4].ToString();


        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            if (!(profileDetails[4].ToString() == "Teacher"))
            {
                teacherPermission permission = new teacherPermission();
                permission.ShowDialog();
                return;
            }

            //ShowForm for create announcement
            frmAnnouncement_create announcementCreate = new frmAnnouncement_create(name, section);
            announcementCreate.ShowDialog();
            loadAnouncements();
        }

        private void frmAnnouncements_Load(object sender, EventArgs e)
        {
            loadAnouncements();
        }

        private void loadAnouncements()
        {
            frmAnnouncementList formAnnouncements = new frmAnnouncementList(section, accountType);
            formAnnouncements.TopLevel = false;
            formAnnouncements.Dock = DockStyle.Fill;
            this.frmPanel.Controls.Add(formAnnouncements);
            this.frmPanel.Tag = formAnnouncements;
            formAnnouncements.Show();
        }
    }
}
