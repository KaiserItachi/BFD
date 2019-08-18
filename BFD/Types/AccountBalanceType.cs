using BFD.Models;
using GraphQL.Types;

namespace BFD.Types
{
    public class AccountBalanceType : ObjectGraphType<AccountBalance>
    {
        public AccountBalanceType()
        {
            Name = "AccountBalance";

            Field(x => x.AccountNumber).Description("Account Number");
            Field(x => x.Month).Description("Month");
            Field(x => x.BankName).Description("Bank Name");
            Field(x => x.Balance).Description("Balance");
        }
    }
}
