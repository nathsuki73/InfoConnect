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
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            signupPg1DesignFix();
            if (rbtnPageOne.Checked == true)
            {
                ShowPageOne();
            }

            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                cmbYear.Items.Add(i);
            }
        }

        public void ShowPageOne() //show controls in page one and hides controls in page two
        {
            piclblName.Visible = true;
            piclblContacts.Visible = true;

            txtFirstName.Visible = true;
            txtMiddleName.Visible = true;
            txtLastName.Visible = true;
            txtEmail.Visible = true;
            txtContactNumber.Visible = true;
            txtEmergencyContactNumber.Visible = true;
            btnNext.Visible = true;
            HidePageTwo();
        }

        public void ShowPageTwo() //show controls in page two and hides controls in page one
        {
            piclblSex.Visible = true;
            piclblPassword.Visible = true;
            piclblDateOfBirth.Visible = true;
            piclblConfirmPassword.Visible = true;

            cmbSex.Visible = true;
            cmbDay.Visible = true;
            cmbMonth.Visible = true;
            cmbYear.Visible = true;

            txtPassword.Visible = true;
            txtConfirmPassword.Visible = true;

            btnSignUp.Visible = true;
            btnBack.Visible = true;
            HidePageOne();
        }

        public void HidePageTwo()
        {
            piclblSex.Visible = false;
            piclblPassword.Visible = false;
            piclblDateOfBirth.Visible = false;
            piclblConfirmPassword.Visible = false;

            cmbSex.Visible = false;
            cmbDay.Visible = false;
            cmbMonth.Visible = false;
            cmbYear.Visible = false;

            txtPassword.Visible = false;
            txtConfirmPassword.Visible = false;

            btnSignUp.Visible = false;
            btnBack.Visible = false;

        }

        public void HidePageOne()
        {
            piclblName.Visible = false;
            piclblContacts.Visible = false;

            txtFirstName.Visible = false;
            txtMiddleName.Visible = false;
            txtLastName.Visible = false;

            txtEmail.Visible = false;
            txtContactNumber.Visible = false;
            txtEmergencyContactNumber.Visible = false;
            btnNext.Visible = false;
        }

        private void signupPg1DesignFix()
        {
            txtFirstName.Parent = pictureBoxSignUp;
            txtLastName.Parent = pictureBoxSignUp;
            txtMiddleName.Parent = pictureBoxSignUp;
            txtEmail.Parent = pictureBoxSignUp;
            txtContactNumber.Parent = pictureBoxSignUp;
            txtEmergencyContactNumber.Parent = pictureBoxSignUp;

            cmbSex.Parent = pictureBoxSignUp;
            cmbDay.Parent = pictureBoxSignUp;
            cmbMonth.Parent = pictureBoxSignUp;
            cmbYear.Parent = pictureBoxSignUp;

            txtPassword.Parent = pictureBoxSignUp;
            txtConfirmPassword.Parent = pictureBoxSignUp;
        }

        

        private void btnBack_Click(object sender, EventArgs e) 
        {
            ShowPageOne();
            rbtnPageOne.Checked = true; 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowPageTwo();
            rbtnPageTwo.Checked = true;
        }

        private void rbtnPageOne_Click(object sender, EventArgs e)
        {
            ShowPageOne();
        }

        private void rbtnPageTwo_Click(object sender, EventArgs e)
        {
            ShowPageTwo();
        }
    }
}
