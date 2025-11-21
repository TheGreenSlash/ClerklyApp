namespace ClerklyUI
{
    partial class LoginToCompanyForm
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
            label1 = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 0;
            label1.Text = "Login To Company";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 114);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(118, 24);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(109, 24);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(136, 111);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(356, 33);
            usernameTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(136, 168);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(356, 33);
            passwordTextbox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(171, 272);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(167, 69);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginToCompanyForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 383);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            Name = "LoginToCompanyForm";
            Text = "LoginToCompanyForm";
            Load += LoginToCompanyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
    }
}