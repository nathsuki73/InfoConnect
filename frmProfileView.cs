using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect
{
    public partial class frmProfileView : Form
    {
        string firstName = "Mhartin";
        string middleName = "Esteban";
        string lastName = "Tolentino";
        string Section;
        string AboutMe;
        string Email;
        string DateCreated;

        PrivateFontCollection privateFont = new PrivateFontCollection();
        frmMain frmMain;
        public frmProfileView(frmMain formMain)
        {
            InitializeComponent();
            AddVisualFont();
            frmMain = formMain;

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfileEdit Profile = new frmProfileEdit(frmMain);
            Profile.Show();
        }

        

        private void frmProfileView_Load(object sender, EventArgs e)
        {
            string processedFullName = NameLengthBreak();
            lblFullName.Text = processedFullName;
        }

        private void frmProfileView_Deactivate(object sender, EventArgs e)
        {
            this.Close();//Close form when focus is gone
        }

        private string NameLengthBreak()
        {
            string name;
            string[] nameArray = {firstName, middleName, lastName };
            string fullName = $"{nameArray[0]} {nameArray[1]} {nameArray[2]}";
            // Split the full name into parts based on spaces
            if (fullName.Length <= 26)
            {
                lblCourseSection.Location = new Point(149, 90); //Adjust the section 
                return fullName;

            }
            else
            {   
                name = $"{nameArray[0]} {nameArray[1][0]}. {nameArray[2]}";
                if (fullName.Length >= 26)
                {
                    name = $"{nameArray[0]}\n{nameArray[1]} {nameArray[2]}";
                    lblCourseSection.Location = new Point(149, 110); //Adjust the section 
                }
            }
            return name;
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
            lblFullName.Font = new Font(privateFont.Families[0], 12, FontStyle.Regular);
            lblCourseSection.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAboutMe.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblEmail.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);
            lblAccountDateCreated.Font = new Font(privateFont.Families[0], 9, FontStyle.Regular);

        }
    }
}
