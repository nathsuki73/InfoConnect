using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;

namespace InfoConnect
{
    public partial class frmProfileEdit : Form
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();
        frmMain formMain;

        private bool isNewFormOpen = false;
        private int userId;
        public frmProfileEdit(frmMain frmMain)
        {
            InitializeComponent();
            formMain = frmMain;
            formMain.Enabled = false;
           //userId = userID;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            AddVisualFont();
           
        }

        private void AddVisualFont()
        {
            // Define the path to the font file
            string fontFilePathNath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
            string fontFilePathGio = "C:\\Users\\gioan\\OneDrive\\Pictures\\InfoConnect\\share-tech-mono\\ShareTechMono-Regular.ttf";


            if (File.Exists(fontFilePathNath))
            {
                privateFont.AddFontFile(fontFilePathNath);
            }
            else if (File.Exists(fontFilePathGio))
            {
                privateFont.AddFontFile(fontFilePathGio);
            }
            else
            {
                // Handle the case where neither font file exists
                throw new FileNotFoundException("The specified font files could not be found.");
            }

            // Create a new font using the private font collection
            Font customFont = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            Font aboutMeCountFont = new Font(privateFont.Families[0], 8, FontStyle.Regular);


            Label[] labels = { lblLastName, lblFirstName, lblMiddleName, lblSex, lblBirthDate, lblAccountType, lblPassword, lblEmail, lblContact, lblAddress };

            foreach (Label lbl in labels)
            {
                lbl.Font = customFont;
            }
            lblAboutMeCount.Font = aboutMeCountFont;

            /*Dictionary<Label, PictureBox> labelParentMap = new Dictionary<Label, PictureBox>
            {
                { lblLastName, guna2PictureBox1 },
                { lblFirstName, guna2PictureBox1 },
                { lblMiddleName, guna2PictureBox1 },
                { lblSex, guna2PictureBox1 },
                { lblBirthDate, guna2PictureBox1 },
                { lblAccountType, guna2PictureBox1 },
                { lblPassword, guna2PictureBox1 },
                { lblEmail, guna2PictureBox1 },
                { lblContact, guna2PictureBox1 },
                { lblAddress, guna2PictureBox1 }
            };*/
            foreach (Label label in labels)
            {
                label.Parent = guna2PictureBox1;
            }
            lblAboutMeCount.Parent = guna2PictureBox1;


        }



        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }


        private frmProfileEditInfo newInfo;
        private void ShowFormEditor(Guna2PictureBox image, string id)
        {
            // Close the currently open form if it exists
            if (newInfo == null || newInfo.IsDisposed)
            {
                newInfo = new frmProfileEditInfo(image.Size, image.Image, id);
                newInfo.Show();
            }
            else
            {
                newInfo.Close();
            }
            

            
        }

        private void btnEditLastName_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbLastName, "Last Name");

        }

        private void btnEditFirstName_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbFirstName, "First Name");

        }

        private void btnEditMiddleName_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbMiddleName, "Middle Name");

        }

        private void btnEditSex_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbSex, "Sex");
        }

        

        private void btnEditAccountType_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbAccountType, "Account Type");
        }

        private void btnEditBirthDate_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbBirthDate, "Birth Date");
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbEmail, "Email");
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbContact, "Contact");
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbAddress, "Address");
        }

        private void btnEditAboutMe_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbAboutMe, "About Me");
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            ShowFormEditor(pcbPassword, "Password");
        }

        private void frmProfileEdit_Deactivate(object sender, EventArgs e)
        {

        }

        private void frmProfileEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProfileView frmProfileView = new frmProfileView(formMain);
            formMain.Enabled = true;
            frmProfileView.Show();
        }
    }
}
