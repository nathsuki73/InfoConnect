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
    public partial class frmProfileEditInfo : Form
    {
        // Define the path to the font file
        string fontFilePathNath = "C:\\Users\\Angelo\\Downloads\\share-tech-mono\\ShareTechMono-Regular.ttf";
        string fontFilePathGio = "C:\\Users\\gioan\\OneDrive\\Pictures\\InfoConnect\\share-tech-mono\\ShareTechMono-Regular.ttf";
        PrivateFontCollection privateFont = new PrivateFontCollection();

        public frmProfileEditInfo(Size newFormSize, Image newImageContainer, string id)
        {
            InitializeComponent();
            //1366,768
            //1350, 729
            // 16, 37  // additional size when I changed the Formborderstyle
            int formWidth = newFormSize.Width + 16;
            int formHeight = newFormSize.Height + 37;
            this.Size = new Size(formWidth, formHeight); // set the size of the form based on the picture
            pcbContainer.Image = newImageContainer;

            txtDate.Visible = false;

            //Change form title
            this.Text = "New " + id;

            //365, 175
            if (id == "About Me")
            {
                txtNewInfo.Width = newFormSize.Width - 22;
                txtNewInfo.Height = 100;
                txtNewInfo.Multiline = true;
                txtNewInfo.MaxLength = 184;
                lbltextCount.Location = new Point(300, 140);
                lbltextCount.Visible = true;
                lbltextCount.Text = $"{txtNewInfo.Text.Length}/184";

            }
            else if (id == "Birth Date")
            {
                txtDate.Visible = true;
                txtDate.Width = newFormSize.Width - 20;

            }
            else if (id == "Account Type")
            {
                txtNewInfo.Visible = false;
                cmbBox.Visible = true;
                cmbBox.Items.Add("Teacher");
                cmbBox.Items.Add("Student");
            }
            else if (id == "Sex")
            {
                txtNewInfo.Visible = false;
                cmbBox.Visible = true;
                cmbBox.Width = 170;
                cmbBox.Items.Add("Male");
                cmbBox.Items.Add("Female");
            }
            
            else
            {
                txtNewInfo.Width = newFormSize.Width - 23;
                //Changing the placeholder for specific form
                if (id == "Address")
                {
                    txtNewInfo.PlaceholderText = $"(House Number) (Street) (Barangay) (City/Municipality) (Province))";

                }
                else if (id == "Email")
                {
                    txtNewInfo.PlaceholderText = $"0000-0000@lspu.edu.ph";
                }
                else if (id == "Contact")
                {
                    txtNewInfo.PlaceholderText = $"09XXXXXXXXX";
                }
                else
                {
                    txtNewInfo.PlaceholderText = $"Type your {id} here...";
                }
            }

 

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
            txtNewInfo.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            txtDate.Font = new Font(privateFont.Families[0], 10, FontStyle.Regular);
            lbltextCount.Font = new Font(privateFont.Families[0], 7, FontStyle.Regular);

            cmbBox.Font = new Font(privateFont.Families[0], 12, FontStyle.Regular);



        }

        private void frmProfileEditInfo_Load(object sender, EventArgs e)
        {

        }

        private void frmProfileEditInfo_Deactivate(object sender, EventArgs e)
        {
            this.Close();//Close form when focus is gone

        }

        private void txtNewInfo_TextChanged(object sender, EventArgs e)
        {
            lbltextCount.Text = $"{txtNewInfo.Text.Length}/184";
        }
    }
}
