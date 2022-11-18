using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public  interface IBankRepository
    {
        void NewAccount(SBAccount acc);
        SBAccount GetAccountDetails(long accno);
        List<SBAccount> GetAllAccounts();
        void DepositAmount(long accno, float amt);
        void WithdrawAmount(long accno, float amt);
        List<SBTransactioncs> GetAllTransactions(long accno);

    }
}
