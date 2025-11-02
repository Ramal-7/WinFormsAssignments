namespace P5_Expense_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Expense Tracker Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Simple validation - in real apps, use proper authentication
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Open Calculator form
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Please enter both username and password", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
