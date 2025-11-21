namespace ClerklyUI
{
    partial class CreatePartyForm
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
            partyNameLabel = new Label();
            partyNameTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            ledgerTypeLabel = new Label();
            ledgerTypeComboBox = new ComboBox();
            startingBalanceLabel = new Label();
            startingBalanceAmountTextBox = new TextBox();
            debitCreditDropdown = new ComboBox();
            saveLedgerButton = new Button();
            label2 = new Label();
            emailTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 0;
            label1.Text = "Create Ledger:";
            label1.Click += label1_Click;
            // 
            // partyNameLabel
            // 
            partyNameLabel.AutoSize = true;
            partyNameLabel.Location = new Point(13, 71);
            partyNameLabel.Name = "partyNameLabel";
            partyNameLabel.Size = new Size(142, 24);
            partyNameLabel.TabIndex = 1;
            partyNameLabel.Text = "Party Name: ";
            partyNameLabel.Click += label2_Click;
            // 
            // partyNameTextBox
            // 
            partyNameTextBox.Location = new Point(161, 62);
            partyNameTextBox.Name = "partyNameTextBox";
            partyNameTextBox.Size = new Size(460, 33);
            partyNameTextBox.TabIndex = 2;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 111);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(94, 24);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(161, 102);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(460, 33);
            addressTextBox.TabIndex = 4;
            // 
            // ledgerTypeLabel
            // 
            ledgerTypeLabel.AutoSize = true;
            ledgerTypeLabel.Location = new Point(13, 231);
            ledgerTypeLabel.Name = "ledgerTypeLabel";
            ledgerTypeLabel.Size = new Size(140, 24);
            ledgerTypeLabel.TabIndex = 5;
            ledgerTypeLabel.Text = "Ledger Type:";
            // 
            // ledgerTypeComboBox
            // 
            ledgerTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ledgerTypeComboBox.FormattingEnabled = true;
            ledgerTypeComboBox.Location = new Point(161, 223);
            ledgerTypeComboBox.Name = "ledgerTypeComboBox";
            ledgerTypeComboBox.Size = new Size(390, 32);
            ledgerTypeComboBox.TabIndex = 6;
            // 
            // startingBalanceLabel
            // 
            startingBalanceLabel.AutoSize = true;
            startingBalanceLabel.Location = new Point(16, 368);
            startingBalanceLabel.Name = "startingBalanceLabel";
            startingBalanceLabel.Size = new Size(181, 24);
            startingBalanceLabel.TabIndex = 7;
            startingBalanceLabel.Text = "Starting Balance:";
            // 
            // startingBalanceAmountTextBox
            // 
            startingBalanceAmountTextBox.Location = new Point(203, 359);
            startingBalanceAmountTextBox.Name = "startingBalanceAmountTextBox";
            startingBalanceAmountTextBox.Size = new Size(245, 33);
            startingBalanceAmountTextBox.TabIndex = 8;
            // 
            // debitCreditDropdown
            // 
            debitCreditDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            debitCreditDropdown.FormattingEnabled = true;
            debitCreditDropdown.Location = new Point(454, 359);
            debitCreditDropdown.Name = "debitCreditDropdown";
            debitCreditDropdown.Size = new Size(97, 32);
            debitCreditDropdown.TabIndex = 9;
            // 
            // saveLedgerButton
            // 
            saveLedgerButton.Location = new Point(240, 429);
            saveLedgerButton.Name = "saveLedgerButton";
            saveLedgerButton.Size = new Size(208, 57);
            saveLedgerButton.TabIndex = 10;
            saveLedgerButton.Text = "Save";
            saveLedgerButton.UseVisualStyleBackColor = true;
            saveLedgerButton.Click += saveLedgerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(161, 147);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(460, 33);
            emailTextBox.TabIndex = 12;
            // 
            // CreatePartyForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(679, 535);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(saveLedgerButton);
            Controls.Add(debitCreditDropdown);
            Controls.Add(startingBalanceAmountTextBox);
            Controls.Add(startingBalanceLabel);
            Controls.Add(ledgerTypeComboBox);
            Controls.Add(ledgerTypeLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(partyNameTextBox);
            Controls.Add(partyNameLabel);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "CreatePartyForm";
            Text = "Create Party Ledger";
            Load += CreatePartyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.TextBox partyNameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label ledgerTypeLabel;
        private System.Windows.Forms.ComboBox ledgerTypeComboBox;
        private System.Windows.Forms.Label startingBalanceLabel;
        private System.Windows.Forms.TextBox startingBalanceAmountTextBox;
        private System.Windows.Forms.ComboBox debitCreditDropdown;
        private System.Windows.Forms.Button saveLedgerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}