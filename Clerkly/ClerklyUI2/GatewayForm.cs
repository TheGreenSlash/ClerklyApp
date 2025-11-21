using ClerklyLibrary.Models;
using System;
using System.CodeDom;
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
    public partial class GatewayForm : Form
    {
        
        private Form previousForm;


        private CompanyModel CurrentCompany;
        List<string> menuItems = new List<string>
        {
            "Alter",
            "Create",
            "Receipt Voucher",
            "Payment Voucher",
            "Sales Vouchers",
            "Purchase Vouchers",
            "Inventory",
            "Accounts",
            "Reports",

        };
        private void LoadFormData(CompanyModel company)
        {
            currentCompanyNameLabel.Text = company.CompanyName;
        }
        public GatewayForm(CompanyModel company)
        {
            InitializeComponent();
            gatewayListBox.DataSource = menuItems;
            this.CurrentCompany = company;
            LoadFormData(CurrentCompany);
        }
        public GatewayForm(CompanyModel company, Form Parent)
        {
            InitializeComponent();
            
            this.FormClosing += GatewayForm_FormClosing;
            
            previousForm = Parent;
            gatewayListBox.DataSource = menuItems;
            LoadFormData(company);
            this.CurrentCompany = company;

        }
        private void GatewayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show(); // Go back to the previous form
            }
        }


        private void gatewayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GatewayForm_Load(object sender, EventArgs e)
        {

        }

        private void openFeatureButton_Click(object sender, EventArgs e)
        {
            switch (gatewayListBox.SelectedItem.ToString())
            {
                case "Alter":
                        
                        break;
                case "Create":
                    CreatePartyForm cpfrm = new CreatePartyForm(this);
                    this.Hide();
                    cpfrm.Show();
                    break;

                case "":
                    break;
                case "Receipt Voucher":
                    ReceiptVoucherForm rcvf = new ReceiptVoucherForm(this.CurrentCompany, this);
                    this.Hide();
                    rcvf.Show();
                    break;
                case "Payment Voucher":
                    break;
                case "Sales Voucher":
                    break;
                case "Purchase Voucher":
                    break;
                case "Inventory":
                    break;
                case "Accounts":
                    break;
                case "Reports":
                    break;
            }
        }
    }
}
