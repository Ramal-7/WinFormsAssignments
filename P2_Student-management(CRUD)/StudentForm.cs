using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P2_Student_management_CRUD_
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                int age = int.Parse(textBox2.Text);
                string className = textBox3.Text;

                Student s = new Student() { Name = name, Age = age, ClassName = className };
                Student.StudentList.Add(s);

                MessageBox.Show("Student added successfully!", "Success");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter valid data!", "Error");
            }

        }
    }
}
