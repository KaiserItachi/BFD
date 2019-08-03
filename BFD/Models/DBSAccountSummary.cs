using System.Collections.Generic;

namespace BFD.Models
{
    public class DBSAccountsSummary
    {
        public List<DBSAccountSummary> CurrentAccounts { get; set; }

        public List<DBSAccountSummary> SavingsAccounts { get; set; }

    }

    public class DBSAccountSummary
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public Balance Balances { get; set; }
    }


    public class Balance
    {
        public AmountDetail TotalBalance { get; set; }
        public AmountDetail AvailableBalance { get; set; }
    }
    public class AmountDetail
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
