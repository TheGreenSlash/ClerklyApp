using ClerklyLibrary.Models;
using ClerklyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClerklyUI
{
    public partial class CreatePartyForm : Form
    {
        
        private Form previousForm;

        List<String> LedgerTypes = new List<String>
            { "Sundry Debtors", "Sundry Creditors", "Purchase Account", "Sales Account", "Direct Expenses", "Bank Account"};
        List<String> balanceType = new List<String>
            { "Debit", "Credit"};
        public CreatePartyForm(Form Parent)
        {
            this.FormClosing += CreatePartyForm_FormClosing;
            InitializeComponent();
            WireUpLists();
            previousForm = Parent;
        }

        private void WireUpLists()
        {
            //List<String> LedgerTypes = new List<String> 
            //{ "Sundry Debtors", "Sundry Creditors", "Purchase Account", "Sales Account", "Direct Expenses", "Bank Account"};
            ledgerTypeComboBox.DataSource = null;

            ledgerTypeComboBox.DataSource = LedgerTypes;
            ledgerTypeComboBox.SelectedIndex = 0;

            debitCreditDropdown.DataSource = null;
            debitCreditDropdown.DataSource = balanceType;
            debitCreditDropdown.SelectedIndex = 0;



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveLedgerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PartyModel model = new PartyModel(
                    partyNameTextBox.Text,
                    addressTextBox.Text,
                    emailTextBox.Text,
                    ledgerTypeComboBox.SelectedItem.ToString(),
                    int.Parse(startingBalanceAmountTextBox.Text),
                    debitCreditDropdown.SelectedItem.ToString()


                    );




                GlobalConfig.Connection.CreateParty(model);
               

                this.Close();


                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";

            }
            else
            {
                MessageBox.Show("This Form Has Invalid Information.");
            }

        }
        private void CreatePartyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show(); // Go back to the previous form
            }
        }


        private bool ValidateForm()
        {
            bool output = true;


            string partyName = partyNameTextBox.Text;

            if (partyName.Length < 5)
            {
                output = false;
            }

            string partyAddress = addressTextBox.Text;


            string partyEmail = emailTextBox.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


            if (partyEmail.Length > 0 && !Regex.IsMatch(partyEmail, pattern))
            {
                output = false;
            }

            string ledgerType = "";
            ledgerType = ledgerTypeComboBox.SelectedItem.ToString();
            if (!LedgerTypes.Contains(ledgerType))
            {
                output = false;

            }



            int startingBalance = 0;
            bool startingBalancerValidNumber = int.TryParse(startingBalanceAmountTextBox.Text, out startingBalance);


            if (!startingBalancerValidNumber)
            {
                output = false;
            }



            return output;
        }

        private void CreatePartyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
