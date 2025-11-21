using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClerklyLibrary.Models;

namespace ClerklyLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateCompany(CompanyModel model);
        void CreateParty(PartyModel model);

        void CreateInventoryItem(ItemModel model);

        void SaveTransaction(TransactionModel model);

        void AlterTransaction(TransactionModel model);

        List<TransactionModel> Get_Transactions_All();

        List<PartyModel> Get_Ledgers_All();
        List<CompanyModel> Get_Company_All();


    }
}
