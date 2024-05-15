using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmSignup : Form
    {

        private ucSignupPageOne page1;
        private ucSignupPageTwo page2;

        public frmSignup()
        {
            InitializeComponent();
            pnlSignup.Parent = pictureBoxSignUp;
            page1 = new ucSignupPageOne();
            page2 = new ucSignupPageTwo();
            ShowPageOne();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            rbtnPageOne.Checked = true;
        }


        private void rbtnPageOne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPageOne.Checked == true)
            {
                ShowPageOne();
                btnBack.Visible = false;
                btnSignUp.Visible = false;
                btnNext.Visible = true;
            }
            else
            {
                ShowPageTwo();
                btnBack.Visible = true;
                btnSignUp.Visible = true;
                btnNext.Visible = false;
            }
        }

        private void ShowPageOne()
        {
            pnlSignup.Controls.Clear(); // Clear any existing controls
            pnlSignup.Controls.Add(page1);
        }

        private void ShowPageTwo()
        {
            pnlSignup.Controls.Clear(); // Clear any existing controls
            pnlSignup.Controls.Add(page2);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            rbtnPageOne.Checked = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rbtnPageTwo.Checked = true;
        }
    }
}
