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
        }

        private void btnStatistics_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_StatisticsTitle;
        }

        private void btnEvents_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_EventsTitle;
        }

        private void btnHandbook_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_HandbookTitle;
        }

        private void btnAnnouncements_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_AnnouncementsTitle;
        }

        private void btnSection_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_SectionTitle;
        }

        private void btnInformationBoard_CheckedChanged(object sender, EventArgs e)
        {
            // Change Title in top bar if button Check state Changes
            pcbTopbarTitle.Image = Properties.Resources.topbar_InformationBoardTitle;
        }
    }
}
