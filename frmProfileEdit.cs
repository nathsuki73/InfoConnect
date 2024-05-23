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

namespace InfoConnect
{
    public partial class frmProfileEdit : Form
    {
        PrivateFontCollection privateFont = new PrivateFontCollection();


        private frmMain frmmain;
        private int userId;
        public frmProfileEdit(frmMain frmMain)
        {
            InitializeComponent();
            this.frmmain = frmMain;
           //userId = userID;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            frmmain.Enabled = false;
            AddVisualFont();
        }

        private void AddVisualFont()
        {
            // Define the path to the font file
            string fontFilePath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
            privateFont.AddFontFile(fontFilePath);

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
            frmmain.Enabled = true;
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
    }
}
