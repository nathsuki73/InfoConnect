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
    public partial class ucSignupPageOne : UserControl
    {
        // Expose a property to access the TextBox text
        public string TextFirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string TextMiddleName
        {
            get { return txtMiddleName.Text; }
            set { txtMiddleName.Text = value; }
        }

        public string TextLastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string TextEmail
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        

        //TODO:add contact and emergency return
        public ucSignupPageOne()
        {
            InitializeComponent();
        }
    }
}
