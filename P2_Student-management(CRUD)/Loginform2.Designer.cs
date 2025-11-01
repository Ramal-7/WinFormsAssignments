namespace P2_Student_management_CRUD_
{
    partial class Loginform2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbluser = new Label();
            lblpass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluser.Location = new Point(112, 64);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(91, 20);
            lbluser.TabIndex = 0;
            lbluser.Text = "Username:";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpass.Location = new Point(112, 140);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(82, 20);
            lblpass.TabIndex = 1;
            lblpass.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(178, 203);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Loginform2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Name = "Loginform2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluser;
        private Label lblpass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnlogin;
    }
}
