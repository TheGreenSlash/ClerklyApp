namespace ClerklyUI
{
    partial class ReceiptVoucherForm
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
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            voucherType = new DataGridViewComboBoxColumn();
            particularsColumn = new DataGridViewComboBoxColumn();
            debitColumn = new DataGridViewTextBoxColumn();
            creditColumn = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DodgerBlue;
            textBox1.Location = new Point(124, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 37;
            label4.Text = "Voucher No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 36;
            label1.Text = "Receipt Voucher";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(359, 7);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 39;
            label2.Text = "<CompanyName>";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { voucherType, particularsColumn, debitColumn, creditColumn });
            dataGridView1.Location = new Point(0, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 296);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // voucherType
            // 
            voucherType.FillWeight = 25.19409F;
            voucherType.HeaderText = "Type";
            voucherType.MinimumWidth = 50;
            voucherType.Name = "voucherType";
            voucherType.Resizable = DataGridViewTriState.True;
            voucherType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // particularsColumn
            // 
            particularsColumn.FillWeight = 369.5432F;
            particularsColumn.HeaderText = "Particulars";
            particularsColumn.MinimumWidth = 350;
            particularsColumn.Name = "particularsColumn";
            particularsColumn.Resizable = DataGridViewTriState.True;
            particularsColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // debitColumn
            // 
            debitColumn.FillWeight = 2.631382F;
            debitColumn.HeaderText = "Debit";
            debitColumn.MinimumWidth = 150;
            debitColumn.Name = "debitColumn";
            // 
            // creditColumn
            // 
            creditColumn.FillWeight = 2.631382F;
            creditColumn.HeaderText = "Credit";
            creditColumn.MinimumWidth = 150;
            creditColumn.Name = "creditColumn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(679, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(149, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(712, 7);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 41;
            label3.Text = "Select Date:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 411);
            label9.Name = "label9";
            label9.Size = new Size(73, 17);
            label9.TabIndex = 44;
            label9.Text = "Narration:";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(12, 431);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(472, 96);
            richTextBox1.TabIndex = 43;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(679, 463);
            button1.Name = "button1";
            button1.Size = new Size(116, 55);
            button1.TabIndex = 45;
            button1.Text = "Save Voucher";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(705, 393);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(127, 26);
            textBox2.TabIndex = 47;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(614, 401);
            label10.Name = "label10";
            label10.Size = new Size(92, 16);
            label10.TabIndex = 46;
            label10.Text = "Total Amount";
            // 
            // ReceiptVoucherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 539);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "ReceiptVoucherForm";
            Text = "ReceiptVoucherForm";
            WindowState = FormWindowState.Maximized;
            Load += ReceiptVoucherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn voucherType;
        private System.Windows.Forms.DataGridViewComboBoxColumn particularsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
    }
}