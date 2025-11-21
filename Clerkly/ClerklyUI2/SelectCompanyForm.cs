using ClerklyLibrary;
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
    public partial class SelectCompanyForm : Form
    {
        List<CompanyModel> companies = GlobalConfig.Connection.Get_Company_All();


        public SelectCompanyForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        public void WireUpLists()
        {
            selectCompanyDropdown.DataSource = null;

            selectCompanyDropdown.DataSource = companies;
            selectCompanyDropdown.DisplayMember = "CompanyName";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectCompanyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyModel cm = (CompanyModel)selectCompanyDropdown.SelectedItem;
            if (cm != null)
            {
                if (cm.CompanyUsername.Length > 0)
                {
                    this.Hide();
                    LoginToCompanyForm loginForm = new LoginToCompanyForm(cm, this);
                    loginForm.Show();

                }
                else
                {
                    this.Hide();
                    GatewayForm frm = new GatewayForm(cm, this);
                    frm.Show();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void createNewCompanyButton_Click(object sender, EventArgs e)
        {
            CreateCompany frm = new CreateCompany(this);
            frm.Show();
            this.Hide();

        }

        private void SelectCompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
