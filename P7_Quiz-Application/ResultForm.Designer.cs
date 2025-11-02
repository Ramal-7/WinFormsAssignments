namespace P7_Quiz_Application
{
    partial class ResultForm
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
            lblScore = new Label();
            lblPercentage = new Label();
            lblMessage = new Label();
            btnRestart = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(321, 142);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(64, 28);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.Location = new Point(299, 203);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(117, 28);
            lblPercentage.TabIndex = 1;
            lblPercentage.Text = "Percentage";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(308, 59);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(86, 25);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(133, 326);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(108, 43);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(502, 326);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRestart);
            Controls.Add(lblMessage);
            Controls.Add(lblPercentage);
            Controls.Add(lblScore);
            Name = "ResultForm";
            Text = "ResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label lblPercentage;
        private Label lblMessage;
        private Button btnRestart;
        private Button button1;
    }
}