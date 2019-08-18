using BFD.Proxy;
using BFD.Types;
using GraphQL.Types;

namespace BFD.Query
{
    public class BFDQuery : ObjectGraphType
    {
        public BFDQuery(AccountDetailProxy accountDetailProxy, CashFlowProxy cashFlowProxy, CustomerProxy customerProxy)
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

            Field<ListGraphType<CustomerType>>(
                "Customer",
                resolve: context =>
                {
                    return customerProxy.GetCustomerList();
                });

            Field<CustomerType>(
                "GetCustomerByCustomerId",
                arguments: new QueryArguments(
                        new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "CustomerId" }
                    ),
                resolve: context => customerProxy.GetCustomerById(context.GetArgument<int>("CustomerId"))
                );
        }
    }
}
