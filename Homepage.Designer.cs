namespace WinFormsApp1
{
    partial class Homepage
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
            lblWelcome = new Label();
            btnProfile = new Button();
            btnSettings = new Button();
            btnProgram3 = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(331, 111);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(54, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1 ";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.ButtonFace;
            btnProfile.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(65, 163);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(4, 2, 4, 2);
            btnProfile.Size = new Size(109, 49);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.ButtonFace;
            btnSettings.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(256, 194);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(4, 2, 4, 2);
            btnSettings.Size = new Size(114, 45);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnProgram3
            // 
            btnProgram3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgram3.Location = new Point(432, 242);
            btnProgram3.Name = "btnProgram3";
            btnProgram3.Size = new Size(94, 60);
            btnProgram3.TabIndex = 3;
            btnProgram3.Text = "Other Program";
            btnProgram3.UseVisualStyleBackColor = true;
            btnProgram3.Click += btnProgram3_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(652, 313);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(4, 2, 4, 2);
            btnLogout.Size = new Size(94, 48);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnProgram3);
            Controls.Add(btnSettings);
            Controls.Add(btnProfile);
            Controls.Add(lblWelcome);
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnProfile;
        private Button btnSettings;
        private Button btnProgram3;
        private Button btnLogout;
    }
}