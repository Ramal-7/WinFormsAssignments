using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_Quiz_Application
{
    public partial class QuizForm : Form
    {
        private Dictionary<int, string> correctAnswers;
        // Store user answers
        private Dictionary<int, string> userAnswers;

        public QuizForm()
        {
            InitializeComponent();
            this.Text = "Quiz Application";
            InitializeQuiz();
            //  ApplyUniqueTextColor(); // Originality Parameter
        }
        private void InitializeQuiz()
        {
            correctAnswers = new Dictionary<int, string>
            {
                { 1, "C" }, // Q1 correct answer is C
                { 2, "A" }, // Q2 correct answer is A
                { 3, "B" }, // Q3 correct answer is B
                { 4, "D" }, // Q4 correct answer is D
                { 5, "A" }  // Q5 correct answer is A
            };

            userAnswers = new Dictionary<int, string>();
        }


        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CollectAnswers();

            // Calculate score
            int score = CalculateScore();

            // Show result form
            ResultForm resultForm = new ResultForm(score, 5); // 5 is total questions
            resultForm.Show();
            this.Hide();

        }
        private void CollectAnswers()
        {
            userAnswers.Clear();

            // Question 1
            if (radioQ1A.Checked) userAnswers[1] = "A";
            else if (radioQ1B.Checked) userAnswers[1] = "B";
            else if (radioQ1C.Checked) userAnswers[1] = "C";
            else if (radioQ1D.Checked) userAnswers[1] = "D";

            // Question 2
            if (radioQ2A.Checked) userAnswers[2] = "A";
            else if (radioQ2B.Checked) userAnswers[2] = "B";
            else if (radioQ2C.Checked) userAnswers[2] = "C";
            else if (radioQ2D.Checked) userAnswers[2] = "D";

            // Question 3
            if (radioQ3A.Checked) userAnswers[3] = "A";
            else if (radioQ3B.Checked) userAnswers[3] = "B";
            else if (radioQ3C.Checked) userAnswers[3] = "C";
            else if (radioQ3D.Checked) userAnswers[3] = "D";

            // Question 4
            if (radioQ4A.Checked) userAnswers[4] = "A";
            else if (radioQ4B.Checked) userAnswers[4] = "B";
            else if (radioQ4C.Checked) userAnswers[4] = "C";
            else if (radioQ4D.Checked) userAnswers[4] = "D";

            // Question 5
            if (radioQ5A.Checked) userAnswers[5] = "A";
            else if (radioQ5B.Checked) userAnswers[5] = "B";
            else if (radioQ5C.Checked) userAnswers[5] = "C";
            else if (radioQ5D.Checked) userAnswers[5] = "D";
        }
        private int CalculateScore()
        {
            int score = 0;

            foreach (var question in correctAnswers)
            {
                int questionNumber = question.Key;
                string correctAnswer = question.Value;

                // Check if user answered this question and if it's correct
                if (userAnswers.ContainsKey(questionNumber) &&
                    userAnswers[questionNumber] == correctAnswer)
                {
                    score++;
                }
            }

            return score;
        }


    }
}
