using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Homepage : Form
    {
        string currentUser;
        public Homepage(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile page navigation");

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Setting page navigation");
        }

        private void btnProgram3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Other program page navigation");
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + currentUser + "!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();

        }
    }
}
