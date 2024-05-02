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
        }

        private void signupPg1DesignFix()
        {
            txtboxfirstname.Parent = pictureBoxSignUp;
            txtboxlastname.Parent = pictureBoxSignUp;
            txtboxmiddlename.Parent = pictureBoxSignUp;
            txtboxaccounttype.Parent = pictureBoxSignUp;
            txtboxinstiaccount.Parent = pictureBoxSignUp;
            pg1SignUpBtnPg1.Parent = pictureBoxSignUp;
            pg1SignUpBtnPg2.Parent = pictureBoxSignUp;
        }

        //eto yung sa dalawang buttons na naglilipat sa page 1 to page 2 ng signup form and vice versa, need lang ifix ng onte kasi nag ooverlap yung mga form pag nalipat ng page ehehe
        private void pg1SignUpBtnPg2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmSignUpPage2 = new frmSignupPage2();
            frmSignUpPage2.Show();


            

        }
    }
}
