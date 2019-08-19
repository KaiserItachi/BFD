using System;
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
                resolve: context => cashFlowProxy.GetCashFlowDetails());

            Field<ListGraphType<AccountBalanceType>>(
                "AccountBalance",
                resolve: context => accountDetailProxy.GetAccountBalances());

            Field<ListGraphType<CustomerType>>(
                "Customer",
                resolve: context => customerProxy.GetCustomerList());

            Field<CustomerType>(
                "GetCustomerByCustomerId",
                arguments: new QueryArguments(
                        new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "customerId" }
                    ),
                resolve: context =>
                {
                    var customerId = context.GetArgument<int>("customerId");
                    return customerProxy.GetCustomerById(customerId);
                });
        }
    }
}
