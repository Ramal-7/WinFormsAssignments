namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" &&  password == "1234")
            {
                Homepage home = new Homepage(username);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
