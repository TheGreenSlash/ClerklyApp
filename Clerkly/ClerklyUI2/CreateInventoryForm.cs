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
    public partial class CreateInventoryForm : Form
    {
        List<string> unitType = new List<string> { "Piece", "Bag" , "Roll", "Box"};
        public CreateInventoryForm()
        {
            
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            
            comboBox1.DataSource = null;
            comboBox1.DataSource = unitType;
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ItemModel model = new ItemModel(
                    itemNameTextBox.Text,
                    int.Parse(opStockTextBox.Text),
                    comboBox1.SelectedItem.ToString()
                    ) ;




                GlobalConfig.Connection.CreateInventoryItem(model);


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

        private bool ValidateForm()
        {
            bool output = true;


            string itemName = itemNameTextBox.Text;

            if (itemName.Length < 5)
            {
                output = false;
            }

            string unit = comboBox1.Text;
            if (!unitType.Contains(unit))
            {
                output = false;
            }

            int opstock = 0;
            bool opStockValidNumber = int.TryParse(opStockTextBox.Text, out opstock);


            if (!opStockValidNumber)
            {
                output = false;
            }

            return output;
        }
    }
}
