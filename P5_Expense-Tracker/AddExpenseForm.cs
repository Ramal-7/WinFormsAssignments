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
    public partial class AddExpenseForm : Form
    {
        private string expensesFile = "expenses.txt";

        public event Action ExpenseAdded;

        public AddExpenseForm()
        {
            InitializeComponent();
            this.Text = "Add New Expense";
            dateTimePicker1.Value = DateTime.Today;
            PopulateExpenseTypes();
        }
        private void PopulateExpenseTypes()
        {
            // Add common expense types to ComboBox
            cmbExpenseType.Items.AddRange(new string[]
            {
                "Food & Dining",
                "Transportation",
                "Entertainment",
                "Utilities",
                "Shopping",
                "Healthcare",
                "Education",
                "Travel",
                "Other"
            });
            // Select first item by default
            if (cmbExpenseType.Items.Count > 0)
                cmbExpenseType.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbExpenseType.SelectedItem == null)
            {
                MessageBox.Show("Please select an expense type", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtAmount.Text) || !decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Prepare expense data
                string expenseType = cmbExpenseType.SelectedItem.ToString();
                string amountStr = amount.ToString("0.00");
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string description = txtDescription.Text;

                // Format: Type|Amount|Date|Description
                string expenseLine = $"{expenseType}|{amountStr}|{date}|{description}";

                // Save to file (append mode)
                using (StreamWriter writer = new StreamWriter(expensesFile, true))
                {
                    writer.WriteLine(expenseLine);
                }

                MessageBox.Show("Expense saved successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Notify Dashboard to refresh
                ExpenseAdded?.Invoke();

                // Clear form for next entry
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving expense: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtAmount.Clear();
            txtDescription.Clear();
            dateTimePicker1.Value = DateTime.Today;
            if (cmbExpenseType.Items.Count > 0)
                cmbExpenseType.SelectedIndex = 0;
        }


    }
}

