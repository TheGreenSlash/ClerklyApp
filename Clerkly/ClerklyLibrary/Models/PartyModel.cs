using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerklyLibrary
{
    public class PartyModel
    {
        public  string PartyName { get; set; }
        public int Id { get; set; }
        public string PartyAddress {  get; set; }
        public string PartyEmail { get; set; }  
        public  string PartyType {  get; set; }

        public int StartingBalance { get; set; }
        public string balanceType { get; set; }
     
        public PartyModel(string pname, string address , string email, string ledgerType, int balance, string btype) {
            PartyName = pname;
            PartyAddress = address;
            PartyEmail = email;
            PartyType = ledgerType;
            StartingBalance = balance;
            balanceType = btype;
            if(balanceType == "Debit")
            {
                StartingBalance = StartingBalance;
            }
            else
            {
                StartingBalance = StartingBalance * -1;
            }


        }
    }
}
