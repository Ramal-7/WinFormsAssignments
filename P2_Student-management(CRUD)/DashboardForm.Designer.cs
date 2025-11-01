namespace P2_Student_management_CRUD_
{
    partial class DashboardForm
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
            btnaddstudent = new Button();
            btnViewStudents = new Button();
            btnexit = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnaddstudent
            // 
            btnaddstudent.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddstudent.Location = new Point(107, 213);
            btnaddstudent.Name = "btnaddstudent";
            btnaddstudent.Size = new Size(147, 54);
            btnaddstudent.TabIndex = 0;
            btnaddstudent.Text = "Add Student";
            btnaddstudent.UseVisualStyleBackColor = true;
            btnaddstudent.Click += btnaddstudent_Click;
            // 
            // btnViewStudents
            // 
            btnViewStudents.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudents.Location = new Point(534, 213);
            btnViewStudents.Name = "btnViewStudents";
            btnViewStudents.Size = new Size(151, 54);
            btnViewStudents.TabIndex = 1;
            btnViewStudents.Text = "View Students";
            btnViewStudents.UseVisualStyleBackColor = true;
            btnViewStudents.Click += btnViewStudents_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(372, 325);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 2;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(313, 117);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 23);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "STUDENT SYSTEM";
            lblTitle.Click += lblTitle_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnexit);
            Controls.Add(btnViewStudents);
            Controls.Add(btnaddstudent);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaddstudent;
        private Button btnViewStudents;
        private Button btnexit;
        private Label lblTitle;
    }
}