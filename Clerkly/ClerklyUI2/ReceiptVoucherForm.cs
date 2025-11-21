using ClerklyLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClerklyUI
{
    public partial class ReceiptVoucherForm : Form
    {
        Form previousForm;
        private CompanyModel currentCompany;
       
        public ReceiptVoucherForm(CompanyModel company, Form Parent)
        {
            this.FormClosing += ReceiptVoucherForm_FormClosing;
            InitializeComponent();
            previousForm = Parent;
            this.currentCompany = company;
            LoadFormData();
        }

        private void LoadFormData()
        {
            label2.Text = currentCompany.CompanyName;
        }
        private void ReceiptVoucherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show(); // Go back to the previous form
            }
        }

        private void ReceiptVoucherForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
