namespace P7_Quiz_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Quiz Applucation - Login";
        }
        private void btnlogin_Click(object sender, EventArgs e)  // Change to lowercase 'l'
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                QuizForm quizForm = new QuizForm();
                quizForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter both username and password", "Login Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
