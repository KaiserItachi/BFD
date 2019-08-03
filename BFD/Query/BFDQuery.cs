using BFD.Proxy;
using BFD.Types;
using GraphQL.Types;

namespace BFD.Query
{
    public class BFDQuery : ObjectGraphType
    {
        public BFDQuery(AccountDetailProxy accountDetailProxy, CashFlowProxy cashFlowProxy)
        {
            Name = "Query";
            Description = ".....";

            Field<ListGraphType<CashFlowType>>(
                "CashFlow",
                resolve: context =>
                {
                    return cashFlowProxy.GetCashFlowDetails();
                });

            Field<ListGraphType<AccountBalanceType>>(
                "AccountBalance",
                resolve: context =>
                {
                    return accountDetailProxy.GetAccountBalances();
                });
        }
    }
}
