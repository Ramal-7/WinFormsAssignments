namespace P4_Simple_Calculator
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Simple validation - in real apps, use proper authentication
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Open Calculator form
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.Show();
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
