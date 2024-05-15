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
    public partial class ucSignupPageTwo : UserControl
    {
        public ucSignupPageTwo()
        {
            InitializeComponent();
            AddYears();
        }

        private void AddYears()
        {
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                cmbYear.Items.Add(i);
            }
        }



    }
}
