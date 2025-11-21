using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClerklyLibrary.Models;

namespace ClerklyLibrary
{
    public class TransactionModel
    {


        public int Id {  get; set; }
        public  string VoucherType { get; set; }
        public List<PartyModel> Transaction { get; set; } = new List<PartyModel>();
        public List<ItemModel>? InvoiceItems { get; set; } = new List<ItemModel>();
        public string[]? Narration { get; set; }

    }
}
