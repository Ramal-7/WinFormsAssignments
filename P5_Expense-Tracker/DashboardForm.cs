using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Expense_Tracker
{
    public partial class DashboardForm : Form
    {
        private string expensesFile = "expenses.txt";

        public DashboardForm()
        {
            InitializeComponent();
            this.Text = "Expense Tracker Dashboard";
            ConfigureDataGridView();
            LoadExpenses();

        }
        private void ConfigureDataGridView()
        {
            // Add columns to DataGridView
            dataGridView1.Columns.Add("Type", "Expense Type");
            dataGridView1.Columns.Add("Amount", "Amount");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Description", "Description");

            // Auto-size columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadExpenses()
        {
            // Clear existing data
            dataGridView1.Rows.Clear();
            // Check if file exists
            if (File.Exists(expensesFile))
            {
                try
                {
                    // Read all lines from file
                    string[] lines = File.ReadAllLines(expensesFile);
                    foreach (string line in lines)
                    {
                        // Split line by delimiter (using pipe | as delimiter)
                        string[] parts = line.Split('|');

                        if (parts.Length == 4)
                        {
                            // Add to DataGridView
                            dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading expenses: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpenseForm = new AddExpenseForm();
            addExpenseForm.ExpenseAdded += RefreshDataGridView;
            addExpenseForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }
        private void RefreshDataGridView()
        {
            LoadExpenses();
        }

    }
}
