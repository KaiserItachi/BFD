using GraphQL.Types;
using BFD.Models;

namespace BFD.Types
{
    public class CashFlowType : ObjectGraphType<CashFlow>
    {
        public CashFlowType()
        {
            Name = "CashFlow";

            Field(x => x.CustomerId).Description("Customer Id");
            Field(x => x.Month).Description("Month");
            Field(x => x.Payable).Description("Payable");
            Field(x => x.Year).Description("Year");
            Field(x => x.Receivable).Description("Receivable");
        }
    }
}
