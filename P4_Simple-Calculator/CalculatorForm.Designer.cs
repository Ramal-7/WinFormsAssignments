namespace P4_Simple_Calculator
{
    partial class CalculatorForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnShowHistory = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(66, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 62);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add(+)";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(221, 223);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(129, 62);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "Subtract(-)";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(404, 223);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(139, 62);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "Multiply(*)";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += button3_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(594, 223);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(116, 62);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "Divide(/)";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowHistory.Location = new Point(275, 351);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(193, 40);
            btnShowHistory.TabIndex = 6;
            btnShowHistory.Text = "Show History";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnShowHistory_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(615, 98);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(71, 28);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnShowHistory);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnShowHistory;
        private Label lblResult;
    }
}