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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Select the Dashboard
            btnDashboard.Checked = true;
        }



        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_DashboardTitle;

            // Change the current form
            loadform(new frmDashboard());
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
            pcbTopbarTitle.Image = Properties.Resources.topbar_HandbookTitle;

            // Change the current form
            loadform(new frmHandbook());
        }

        private void btnAnnouncements_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_AnnouncementsTitle;

            // Change the current form
            loadform(new frmAnnouncements());
        }

        private void btnSection_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_SectionTitle;

            // Change the current form
            loadform(new frmSection());
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
    }
}
