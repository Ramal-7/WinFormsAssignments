using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace P7_Quiz_Application
{
    public partial class ResultForm : Form
    {
        public ResultForm(int score, int totalQuestions)
        {
            InitializeComponent();
            this.Text = "Quiz Results";
            DisplayResults(score, totalQuestions);

        }

        private void DisplayResults(int score, int totalQuestions)
        {
            lblScore.Text = $"Your Score: {score}/{totalQuestions}";

            // Calculate percentage
            double percentage = (double)score / totalQuestions * 100;
            lblPercentage.Text = $"Percentage: {percentage:0.00}%";

            // Display message based on performance
            if (percentage >= 80)
            {
                lblMessage.Text = "Excellent! 🎉";
                lblMessage.ForeColor = Color.Green;
            }
            else if (percentage >= 60)
            {
                lblMessage.Text = "Good Job! 👍";
                lblMessage.ForeColor = Color.Blue;
            }
            else if (percentage >= 40)
            {
                lblMessage.Text = "Not Bad! 😊";
                lblMessage.ForeColor = Color.Orange;
            }
            else
            {
                lblMessage.Text = "Keep Practicing! 💪";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Go back to login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
