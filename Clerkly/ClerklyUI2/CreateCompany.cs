using ClerklyLibrary;
using ClerklyLibrary.Models;
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
    public partial class CreateCompany : Form
    {

        private bool companyCreated = false;
        private Form previousForm;
        public CreateCompany(Form Parent)
        {
            this.FormClosing += CreateCompanyForm_FormClosing;
            InitializeComponent();
            previousForm = Parent;
        }

        private void createCompanyButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CompanyModel model = new CompanyModel(
                    companyNameTextBox.Text,
                    companyAddressTextBox.Text,
                    companyEmailTextBox.Text,
                    companyTelephoneTextBox.Text,
                    fyearPicker.Value.Date,
                    setUsernameTextBox.Text,
                    setPasswordTextBox.Text);




                GlobalConfig.Connection.CreateCompany(model);
                companyCreated = true;
                GatewayForm frm = new GatewayForm(model);
                frm.Show();
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
        private void CreateCompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!companyCreated && previousForm != null)
            {
                previousForm.Show(); // Go back to the previous form
            }
        }




        private bool ValidateForm()
        {
            bool output = true;


            string companyName = companyNameTextBox.Text;

            if (companyName.Length < 5)
            {
                output = false;
            }

            string companyAddress = companyAddressTextBox.Text;


            string companyEmail = companyEmailTextBox.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


            if (companyEmail.Length > 0 && !Regex.IsMatch(companyEmail, pattern))
            {
                output = false;
            }


            int telephoneNumber = 0;
            bool telephoneNumberValidNumber = int.TryParse(companyTelephoneTextBox.Text, out telephoneNumber);


            if (!telephoneNumber.Equals(0) && !(telephoneNumber.ToString().StartsWith("97") || telephoneNumber.ToString().StartsWith("98")))
            {
                output = false;
            }

            DateTime fiscalYear = fyearPicker.Value.Date;

            string companyUsername = setUsernameTextBox.Text;
            string companyPassword = setPasswordTextBox.Text;
            if (companyUsername.Length == 0 && companyPassword.Length != 0)
            {
                output = false;
            }
            if (companyUsername.Length != 0 && companyPassword.Length == 0)
            {
                output = false;
            }



            return output;
        }

        private void CreateCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
