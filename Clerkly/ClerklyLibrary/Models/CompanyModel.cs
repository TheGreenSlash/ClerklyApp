using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClerklyLibrary.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        public string? CompanyEmail { get; set; }
        public int CompanyTelephone { get; set; }
        public DateTime FiscalDate { get; set; }
        public string CompanyUsername { get; set; }

        public string CompanyPassword { get; set; }
        public CompanyModel()
        {

        }
        public CompanyModel(string name, string address, string email,string telephone,  DateTime fyear, string uname, string password) {
            CompanyName = name;
            CompanyAddress = address;
            CompanyEmail = email;
            int number = 0;
            int.TryParse(telephone, out number);
            CompanyTelephone = number;
            FiscalDate = fyear;
            CompanyUsername = uname;
            CompanyPassword = password;
        }


    }
}
