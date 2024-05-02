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
    public partial class frmSignupPage2 : Form
    {
        public frmSignupPage2()
        {
            InitializeComponent();
        }

        private void frmSignupPage2_Load(object sender, EventArgs e)
        {
            signupPg2DesignFix();
        }

        private void signupPg2DesignFix()
        {
            txtbxbirthdate.Parent = pictureBoxSignUpPg2;
            txtbxsex.Parent = pictureBoxSignUpPg2;
            txtbxenterpass.Parent = pictureBoxSignUpPg2;
            txtbxconfirmpass.Parent = pictureBoxSignUpPg2;
            pg2SignUpBtnPg1.Parent = pictureBoxSignUpPg2;
            pg2SignUpBtnPg2.Parent = pictureBoxSignUpPg2;
        }

        //eto yung sa dalawang buttons na naglilipat sa page 1 to page 2 ng signup form and vice versa, need lang ifix ng onte kasi nag ooverlap yung mga form pag nalipat ng page ehehe
        private void pg2SignUpBtnPg1_Click(object sender, EventArgs e)
        {
            Form frmSignUp = new frmSignup();
            frmSignUp.Show();
            
        }




    }
}
