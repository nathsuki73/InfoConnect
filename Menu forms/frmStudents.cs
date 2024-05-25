using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoConnect.Menu_forms
{
    public partial class frmStudents : Form
    {
        Dictionary<int, string> students;
        public frmStudents(Dictionary<int, string> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            int newPoint = 0;
            Point location = new Point(0, newPoint);
            foreach (var item in students)
            {
                ucStudent newStudent = new ucStudent();
                newStudent.TextFirstName = item.Value;
                newStudent.Location = location;
                this.Controls.Add(newStudent); // Add the new control to the form's controls collection
                newPoint = newPoint + 36;
                location = new Point(0, newPoint);
            }

        }
    }
}
