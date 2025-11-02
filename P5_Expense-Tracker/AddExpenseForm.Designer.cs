namespace P5_Expense_Tracker
{
    partial class AddExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbExpenseType = new ComboBox();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // cmbExpenseType
            // 
            cmbExpenseType.FormattingEnabled = true;
            cmbExpenseType.Location = new Point(147, 70);
            cmbExpenseType.Name = "cmbExpenseType";
            cmbExpenseType.Size = new Size(151, 28);
            cmbExpenseType.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(146, 153);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(147, 220);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(112, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 156);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 223);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 75);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 73);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 7;
            label4.Text = "Expense Type:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(544, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // AddExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(cmbExpenseType);
            Name = "AddExpenseForm";
            Text = "AddExpenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbExpenseType;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}