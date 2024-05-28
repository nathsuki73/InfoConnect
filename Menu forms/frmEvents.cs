using Mysqlx.Crud;
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
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmEvents_create createEvent = new frmEvents_create();
            createEvent.Show();
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            ucEventView eventView = new ucEventView();
            eventView.mainPanel = this.panel1;
            eventView.Location = new Point(1017, 45);
            this.Controls.Add(eventView);

        }
    }
}
