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
        public string TextSex
        {
            get { return cmbSex.Text; }
            set { cmbSex.Text = value; }
        }

        public int TextMonth
        {
            get { return cmbMonth.SelectedIndex; }
            set {
                if (value >= 0 && value < cmbMonth.Items.Count)
                {
                    cmbMonth.SelectedIndex = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be within the range of available indices.");
                }
            }
        }

        public string TextDay
        {
            get { return cmbDay.Text; }
            set { cmbDay.Text = value; }
        }

        public string TextYear
        {
            get { return cmbYear.Text; }
            set { cmbYear.Text = value; }
        }
        public string TextPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string TextConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
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

            int selectedMonth = cmbMonth.SelectedIndex;
            int selectedYear;

            if (!int.TryParse(cmbYear.SelectedItem.ToString(), out selectedYear))
            {
                selectedYear = 2000;
            }

            bool isLeapYear = DateTime.IsLeapYear(selectedYear);

            cmbDay.Items.Add("Day");
            if (selectedMonth != 0)
            {
                int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);
                for (int i = 1; i <= daysInMonth; i++)
                {
                    cmbDay.Items.Add(i);
                }
            }


            cmbDay.SelectedIndex = 0;
            cmbDay.Refresh();


        }


        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDays();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDays();
        }
    }
}
