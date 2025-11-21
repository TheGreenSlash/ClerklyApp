namespace ClerklyUI
{
    partial class CreateInventoryForm
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
            label2 = new Label();
            itemNameTextBox = new TextBox();
            UnitLabel = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            opStockTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 24);
            label1.TabIndex = 0;
            label1.Text = "Create Inventory Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(99, 65);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.RightToLeft = RightToLeft.Yes;
            itemNameTextBox.Size = new Size(483, 33);
            itemNameTextBox.TabIndex = 2;
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Location = new Point(13, 142);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(51, 24);
            UnitLabel.TabIndex = 3;
            UnitLabel.Text = "Unit:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 32);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 215);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 5;
            label3.Text = "Opening Stock:";
            label3.Click += label3_Click;
            // 
            // opStockTextBox
            // 
            opStockTextBox.Location = new Point(204, 206);
            opStockTextBox.Name = "opStockTextBox";
            opStockTextBox.RightToLeft = RightToLeft.Yes;
            opStockTextBox.Size = new Size(203, 33);
            opStockTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(191, 334);
            button1.Name = "button1";
            button1.Size = new Size(188, 57);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateInventoryForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(592, 420);
            Controls.Add(button1);
            Controls.Add(opStockTextBox);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(UnitLabel);
            Controls.Add(itemNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            Margin = new Padding(6);
            Name = "CreateInventoryForm";
            Text = "CreateInventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opStockTextBox;
        private System.Windows.Forms.Button button1;
    }
}