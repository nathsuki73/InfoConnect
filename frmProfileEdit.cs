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

        private void btnEditLastName_Click(object sender, EventArgs e)
        {
            frmProfileEditInfo newInfo = new frmProfileEditInfo(pcbLastName.Size, pcbLastName.Image);
            newInfo.Show();

        }
    }
}
