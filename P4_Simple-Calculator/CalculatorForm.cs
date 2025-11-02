using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Simple_Calculator
{
    public partial class CalculatorForm : Form
    {
        private List<string> calculationHistory = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
            this.Text = "Calculator - Ramal";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformCalculation('*');

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation('+');

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation('-');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation('/');
        }
        private void PerformCalculation(char operation)
        {
            try
            {
                // Get numbers from textboxes
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;
                string operationSymbol = "";

                // Perform calculation based on operation
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        operationSymbol = "+";
                        break;
                    case '-':
                        result = num1 - num2;
                        operationSymbol = "-";
                        break;
                    case '*':
                        result = num1 * num2;
                        operationSymbol = "×";
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = num1 / num2;
                        operationSymbol = "÷";
                        break;
                }
                // Display result
                lblResult.Text = $"Result: {result}";

                // Add to history
                string historyEntry = $"{num1} {operationSymbol} {num2} = {result}";
                calculationHistory.Add(historyEntry);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            // Open History Form
            HistoryForm historyForm = new HistoryForm(calculationHistory);
            historyForm.Show();

        }
    }
}
