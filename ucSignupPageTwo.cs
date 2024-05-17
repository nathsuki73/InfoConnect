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

        public string TextPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
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

        private void AddDays()
        {
            cmbDay.Items.Clear();

            if (cmbMonth.SelectedIndex == 1 || cmbMonth.SelectedIndex == 3 || cmbMonth.SelectedIndex == 5 || cmbMonth.SelectedIndex == 7 || cmbMonth.SelectedIndex == 8 || cmbMonth.SelectedIndex == 10 || cmbMonth.SelectedIndex == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    cmbDay.Items.Add(i);
                }
            }
            else if (cmbMonth.SelectedIndex == 2)
            {
                if ((string)cmbYear.SelectedItem == "Year" || (int)(cmbYear.SelectedItem) % 4 != 0)
                {
                    for (int i = 1; i <= 28; i++)
                    {
                        cmbDay.Items.Add(i);
                    }
                }
                else if ((int)(cmbYear.SelectedItem) % 4 == 0)
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        cmbDay.Items.Add(i);
                    }
                }
                
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    cmbDay.Items.Add(i);
                }
            }
        }

        private void cmbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            AddDays();
        }

        private void cmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            AddDays();
        }
    }
}
