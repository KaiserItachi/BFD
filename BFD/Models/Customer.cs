using System;
using System.Collections.Generic;

namespace BFD.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<AccountBalance> AccountBalanceList { get; set; }
        public List<CashFlow> CashFlowList { get; set; }
    }
}
