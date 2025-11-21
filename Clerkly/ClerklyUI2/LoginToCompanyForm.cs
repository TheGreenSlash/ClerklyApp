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
    public partial class LoginToCompanyForm : Form
    {
        private CompanyModel company;
        private Form previousForm;
        private bool loggedIn = false;
        public LoginToCompanyForm(CompanyModel company, Form Parent)
        {
            InitializeComponent();
            this.company = company;
            this.FormClosing += LoginToCompanyForm_FormClosing;
            previousForm = Parent;
        }


        private void LoginToCompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedIn && previousForm != null)
            {
                previousForm.Show(); // Go back to the previous form
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                GatewayForm frm = new GatewayForm(company);
                frm.Show();
                loggedIn = true;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;


            string username = company.CompanyUsername;
            string password = company.CompanyPassword;

            if (username != null && password != null)
            {
                if (!(usernameTextbox.Text == username))
                {
                    output = false;
                }
                else if (!(passwordTextbox.Text == password))
                {
                    output = false;
                }
            }




            return output;
        }

        private void LoginToCompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
