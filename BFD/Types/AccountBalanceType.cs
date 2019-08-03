using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Field(x => x.AccountType).Description("Account Type");
            Field(x => x.BankName).Description("Bank Name");
            Field(x => x.Balance).Description("Balance");
        }
    }
}
