using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Student_management_CRUD_
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            StudentForm add = new StudentForm();
            add.ShowDialog();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm view = new ViewStudentsForm();
            view.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Student system by Ramal";
        }
    }
}
