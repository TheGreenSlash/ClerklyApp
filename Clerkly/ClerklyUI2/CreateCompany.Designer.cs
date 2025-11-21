using System;

namespace ClerklyUI
{
    partial class CreateCompany
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
            companyNameLabel = new Label();
            addressLabel = new Label();
            companyNameTextBox = new TextBox();
            companyAddressTextBox = new TextBox();
            label1 = new Label();
            companyEmailTextBox = new TextBox();
            label2 = new Label();
            companyTelephoneTextBox = new TextBox();
            label3 = new Label();
            fyearPicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            setUsernameTextBox = new TextBox();
            setPasswordTextBox = new TextBox();
            createCompanyButton = new Button();
            SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(13, 27);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(80, 24);
            companyNameLabel.TabIndex = 0;
            companyNameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 76);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(94, 24);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Location = new Point(198, 18);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(538, 33);
            companyNameTextBox.TabIndex = 2;
            // 
            // companyAddressTextBox
            // 
            companyAddressTextBox.Location = new Point(198, 67);
            companyAddressTextBox.Name = "companyAddressTextBox";
            companyAddressTextBox.Size = new Size(538, 33);
            companyAddressTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // companyEmailTextBox
            // 
            companyEmailTextBox.Location = new Point(198, 120);
            companyEmailTextBox.Name = "companyEmailTextBox";
            companyEmailTextBox.Size = new Size(538, 33);
            companyEmailTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 6;
            label2.Text = "Telephone:";
            // 
            // companyTelephoneTextBox
            // 
            companyTelephoneTextBox.Location = new Point(198, 161);
            companyTelephoneTextBox.Name = "companyTelephoneTextBox";
            companyTelephoneTextBox.Size = new Size(538, 33);
            companyTelephoneTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 248);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 8;
            label3.Text = "Financial Year:";
            // 
            // fyearPicker
            // 
            fyearPicker.Format = DateTimePickerFormat.Short;
            fyearPicker.Location = new Point(198, 237);
            fyearPicker.Name = "fyearPicker";
            fyearPicker.Size = new Size(161, 33);
            fyearPicker.TabIndex = 9;
            fyearPicker.Value = new DateTime(2025, 7, 16, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 302);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 10;
            label4.Text = "Security";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 345);
            label5.Name = "label5";
            label5.Size = new Size(155, 24);
            label5.TabIndex = 11;
            label5.Text = "Set Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 387);
            label6.Name = "label6";
            label6.Size = new Size(152, 24);
            label6.TabIndex = 12;
            label6.Text = "Set Password: ";
            // 
            // setUsernameTextBox
            // 
            setUsernameTextBox.Location = new Point(198, 336);
            setUsernameTextBox.Name = "setUsernameTextBox";
            setUsernameTextBox.Size = new Size(538, 33);
            setUsernameTextBox.TabIndex = 13;
            // 
            // setPasswordTextBox
            // 
            setPasswordTextBox.Location = new Point(198, 378);
            setPasswordTextBox.Name = "setPasswordTextBox";
            setPasswordTextBox.Size = new Size(538, 33);
            setPasswordTextBox.TabIndex = 14;
            // 
            // createCompanyButton
            // 
            createCompanyButton.Location = new Point(258, 443);
            createCompanyButton.Name = "createCompanyButton";
            createCompanyButton.Size = new Size(260, 43);
            createCompanyButton.TabIndex = 15;
            createCompanyButton.Text = "Create Company";
            createCompanyButton.UseVisualStyleBackColor = true;
            createCompanyButton.Click += createCompanyButton_Click;
            // 
            // CreateCompany
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(768, 536);
            Controls.Add(createCompanyButton);
            Controls.Add(setPasswordTextBox);
            Controls.Add(setUsernameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(fyearPicker);
            Controls.Add(label3);
            Controls.Add(companyTelephoneTextBox);
            Controls.Add(label2);
            Controls.Add(companyEmailTextBox);
            Controls.Add(label1);
            Controls.Add(companyAddressTextBox);
            Controls.Add(companyNameTextBox);
            Controls.Add(addressLabel);
            Controls.Add(companyNameLabel);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "CreateCompany";
            Text = "Create Company";
            Load += CreateCompany_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyEmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyTelephoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fyearPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox setUsernameTextBox;
        private System.Windows.Forms.TextBox setPasswordTextBox;
        private System.Windows.Forms.Button createCompanyButton;
    }
}