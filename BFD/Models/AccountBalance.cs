using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFD.Models
{
    public class AccountBalance
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }
        public string Month { get; set; }
    }
}
