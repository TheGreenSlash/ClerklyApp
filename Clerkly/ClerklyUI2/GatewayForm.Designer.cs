namespace ClerklyUI
{
    partial class GatewayForm
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
            currentCompanyLabel = new Label();
            currentCompanyNameLabel = new Label();
            gatewayListBox = new ListBox();
            label1 = new Label();
            openFeatureButton = new Button();
            alterCompanyButton = new Button();
            SuspendLayout();
            // 
            // currentCompanyLabel
            // 
            currentCompanyLabel.AutoSize = true;
            currentCompanyLabel.Location = new Point(12, 81);
            currentCompanyLabel.Name = "currentCompanyLabel";
            currentCompanyLabel.Size = new Size(188, 22);
            currentCompanyLabel.TabIndex = 0;
            currentCompanyLabel.Text = "Current Company: ";
            // 
            // currentCompanyNameLabel
            // 
            currentCompanyNameLabel.AutoSize = true;
            currentCompanyNameLabel.Location = new Point(12, 122);
            currentCompanyNameLabel.Name = "currentCompanyNameLabel";
            currentCompanyNameLabel.Size = new Size(180, 22);
            currentCompanyNameLabel.TabIndex = 1;
            currentCompanyNameLabel.Text = "<companyName>";
            // 
            // gatewayListBox
            // 
            gatewayListBox.FormattingEnabled = true;
            gatewayListBox.ItemHeight = 22;
            gatewayListBox.Location = new Point(354, 81);
            gatewayListBox.Name = "gatewayListBox";
            gatewayListBox.Size = new Size(309, 400);
            gatewayListBox.TabIndex = 2;
            gatewayListBox.SelectedIndexChanged += gatewayListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 43);
            label1.Name = "label1";
            label1.Size = new Size(187, 22);
            label1.TabIndex = 3;
            label1.Text = "Gateway of Clerkly";
            // 
            // openFeatureButton
            // 
            openFeatureButton.Location = new Point(680, 81);
            openFeatureButton.Name = "openFeatureButton";
            openFeatureButton.Size = new Size(114, 45);
            openFeatureButton.TabIndex = 4;
            openFeatureButton.Text = "Open";
            openFeatureButton.UseVisualStyleBackColor = true;
            openFeatureButton.Click += openFeatureButton_Click;
            // 
            // alterCompanyButton
            // 
            alterCompanyButton.Location = new Point(26, 356);
            alterCompanyButton.Name = "alterCompanyButton";
            alterCompanyButton.Size = new Size(263, 61);
            alterCompanyButton.TabIndex = 6;
            alterCompanyButton.Text = "Alter Company";
            alterCompanyButton.UseVisualStyleBackColor = true;
            // 
            // GatewayForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 567);
            Controls.Add(alterCompanyButton);
            Controls.Add(openFeatureButton);
            Controls.Add(label1);
            Controls.Add(gatewayListBox);
            Controls.Add(currentCompanyNameLabel);
            Controls.Add(currentCompanyLabel);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "GatewayForm";
            Text = "Gateway";
            Load += GatewayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label currentCompanyLabel;
        private System.Windows.Forms.Label currentCompanyNameLabel;
        private System.Windows.Forms.ListBox gatewayListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFeatureButton;
        private System.Windows.Forms.Button createNewCompanyButton;
        private System.Windows.Forms.Button alterCompanyButton;
    }
}