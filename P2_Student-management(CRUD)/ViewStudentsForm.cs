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
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = Student.StudentList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (dgvStudents.CurrentRow != null)
                {
                    Student selected = (Student)dgvStudents.CurrentRow.DataBoundItem;
                    Student.StudentList.Remove(selected);
                    dgvStudents.DataSource = null;
                    dgvStudents.DataSource = Student.StudentList;
                    MessageBox.Show("Student deleted!");
                }

            }
        }
    }
}
