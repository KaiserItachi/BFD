using BFD.Models;
using BFD.Proxy;
using System.Collections.Generic;

namespace BFD.Services
{
    public class CashFlowService
    {
        private readonly CashFlowProxy _cashFlowProxy;

        public CashFlowService(CashFlowProxy cashFlowProxy)
        {
            _cashFlowProxy = cashFlowProxy;
        }

        public List<CashFlow> GetCashFlowDetails()
        {
            return _cashFlowProxy.GetCashFlowDetails();
        }
    }
}
