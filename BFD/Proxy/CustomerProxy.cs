using System.Collections.Generic;
using System.Linq;
using BFD.Models;

namespace BFD.Proxy
{
    public class CustomerProxy
    {
        private AccountDetailProxy _accountDetailProxy;
        private CashFlowProxy _cashFlowProxy;

        public CustomerProxy()
        {
            _accountDetailProxy = new AccountDetailProxy();
            _cashFlowProxy = new CashFlowProxy();
        }

        public List<Customer> GetCustomerList()
        {
            var custom1Account = _accountDetailProxy.GetAccountBalances().Where(x => x.CustomerId == 1).ToList();
            var custom1CashFLow = _cashFlowProxy.GetCashFlowDetails().Where(x => x.CustomerId == 1).ToList();

            return new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Name= "Aiswarya",
                    AccountBalanceList = custom1Account,
                    CashFlowList = custom1CashFLow
                },

                new Customer
                {
                    CustomerId = 2,
                    Name= "Hema",
                    AccountBalanceList = _accountDetailProxy.GetAccountBalances().Where(x=> x.CustomerId == 2).ToList(),
                    CashFlowList = _cashFlowProxy.GetCashFlowDetails().Where(x=> x.CustomerId ==2).ToList()
                }
            };
        }

        public Customer GetCustomerById(int customerId)
        {
            return GetCustomerList().FirstOrDefault(x => x.CustomerId == customerId);
        }
    }
}
