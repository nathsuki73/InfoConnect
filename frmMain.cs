using InfoConnect.Info_Forms;
using InfoConnect.Menu_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmMain : Form
    {
        object[] profileDetails;

        public frmMain(object[] profileDetails)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Select the Dashboard
            btnDashboard.Checked = true;
            loggedIn login = new loggedIn();
            login.Hide();
        }



        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_DashboardTitle;

            // Change the current form
            loadform(new frmDashboard(profileDetails, this));
            
        }

        private void btnStatistics_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_StatisticsTitle;

            // Change the current form
            loadform(new frmStatistics());
        }

        private void btnEvents_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_EventsTitle;

            // Change the current form
            loadform(new frmEvents());
        }

        private void btnHandbook_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.ABOUT_US_DASH;

            // Change the current form
            loadform(new frmAboutUs());
        }

        private void btnAnnouncements_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_AnnouncementsTitle;

            // Change the current form
            loadform(new frmAnnouncements(profileDetails));
        }

        private void btnSection_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_SectionTitle;

            // Change the current form
            loadform(new frmSection(profileDetails));

        }

        private void btnInformationBoard_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_InformationBoardTitle;

            // Change the current form
            loadform(new frmInformationBoard());
        }

        //============= Changing Form
        public void loadform(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.Clear();
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            this.pnlMain.Tag = form;
            form.Show();
        }

        //opens the frmSettings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings(this);
            Settings.Show();
            //this.Enabled = false;
            //this.Opacity = 0.5;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfileView Profile = new frmProfileView(this, Convert.ToInt32(profileDetails[0]));
            Profile.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnAnnouncements.Checked == true)
            {
                btnAnnouncements.Checked = false;
                btnAnnouncements.Checked = true;
            }
            if (btnEvents.Checked == true)
            {
                btnEvents.Checked = false;
                btnEvents.Checked = true;
            }
        }
    }
}
