namespace ClerklyUI
{
    partial class SelectCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCompanyForm));
            label1 = new Label();
            clerklyLabel = new Label();
            selectCompanyLabel = new Label();
            selectCompanyDropdown = new ComboBox();
            loadCompanyButton = new Button();
            createNewCompanyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 127);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 0;
            // 
            // clerklyLabel
            // 
            clerklyLabel.Anchor = AnchorStyles.Top;
            clerklyLabel.AutoSize = true;
            clerklyLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clerklyLabel.Location = new Point(174, 28);
            clerklyLabel.Name = "clerklyLabel";
            clerklyLabel.Size = new Size(272, 32);
            clerklyLabel.TabIndex = 1;
            clerklyLabel.Text = "Welcome To Clerkly";
            clerklyLabel.Click += label2_Click;
            // 
            // selectCompanyLabel
            // 
            selectCompanyLabel.AutoSize = true;
            selectCompanyLabel.Location = new Point(12, 102);
            selectCompanyLabel.Name = "selectCompanyLabel";
            selectCompanyLabel.Size = new Size(244, 33);
            selectCompanyLabel.TabIndex = 2;
            selectCompanyLabel.Text = "Select Company:";
            // 
            // selectCompanyDropdown
            // 
            selectCompanyDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCompanyDropdown.FormattingEnabled = true;
            selectCompanyDropdown.Location = new Point(18, 151);
            selectCompanyDropdown.Name = "selectCompanyDropdown";
            selectCompanyDropdown.Size = new Size(582, 41);
            selectCompanyDropdown.TabIndex = 3;
            selectCompanyDropdown.SelectedIndexChanged += selectCompanyDropdown_SelectedIndexChanged;
            // 
            // loadCompanyButton
            // 
            loadCompanyButton.Anchor = AnchorStyles.Bottom;
            loadCompanyButton.Location = new Point(211, 318);
            loadCompanyButton.Name = "loadCompanyButton";
            loadCompanyButton.Size = new Size(183, 51);
            loadCompanyButton.TabIndex = 4;
            loadCompanyButton.Text = "Continue";
            loadCompanyButton.UseVisualStyleBackColor = true;
            loadCompanyButton.Click += loadCompanyButton_Click;
            // 
            // createNewCompanyButton
            // 
            createNewCompanyButton.Anchor = AnchorStyles.Bottom;
            createNewCompanyButton.Location = new Point(174, 408);
            createNewCompanyButton.Name = "createNewCompanyButton";
            createNewCompanyButton.Size = new Size(272, 58);
            createNewCompanyButton.TabIndex = 5;
            createNewCompanyButton.Text = "Create New";
            createNewCompanyButton.UseVisualStyleBackColor = true;
            createNewCompanyButton.Click += createNewCompanyButton_Click;
            // 
            // SelectCompanyForm
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 501);
            Controls.Add(createNewCompanyButton);
            Controls.Add(loadCompanyButton);
            Controls.Add(selectCompanyDropdown);
            Controls.Add(selectCompanyLabel);
            Controls.Add(clerklyLabel);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(8);
            MaximizeBox = false;
            Name = "SelectCompanyForm";
            Text = "Select Company";
            Load += SelectCompanyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clerklyLabel;
        private System.Windows.Forms.Label selectCompanyLabel;
        private System.Windows.Forms.ComboBox selectCompanyDropdown;
        private System.Windows.Forms.Button loadCompanyButton;
        private Button createNewCompanyButton;
    }
}

