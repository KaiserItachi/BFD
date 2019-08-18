using GraphQL.Types;
using BFD.Models;
using BFD.Proxy;
using System.Linq;

namespace BFD.Types
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        AccountDetailProxy accountDetailProxy = new AccountDetailProxy();
        CashFlowProxy cashFlowProxy = new CashFlowProxy();

        public CustomerType()
        {
            Name = "Customer";
            Description = "Customer Related Informations";

            Field(x => x.CustomerId).Description("Customer Id");
            Field(x => x.Name).Description("Name");
            Field<ListGraphType<AccountBalanceType>>(
                "AccountBalance",
                resolve: context =>
                    accountDetailProxy.GetAccountBalances()
                    .Where(x=> x.CustomerId == context.Source.CustomerId).ToList());
            Field<ListGraphType<CashFlowType>>(
                "CashFlow",
                resolve: context =>
                    cashFlowProxy.GetCashFlowDetails()
                    .Where(x => x.CustomerId == context.Source.CustomerId).ToList());
        }
    }
}
