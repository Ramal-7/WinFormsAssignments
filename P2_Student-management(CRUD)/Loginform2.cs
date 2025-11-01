namespace P2_Student_management_CRUD_
{
    public partial class Loginform2 : Form
    {
        public Loginform2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user == "admin" && pass == "1234")
            {
                DashboardForm dash = new DashboardForm();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
