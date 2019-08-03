using BFD.Models;
using BFD.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFD.Controllers
{
    [Route("api/[controller]")]
    public class BusinessFinanceDashboardController : Controller
    {
        private AccountDetailService _accountDetailService;
        public CashFlowService _cashFlowService;

        public BusinessFinanceDashboardController(AccountDetailService accountDetailService, CashFlowService cashFlowService)
        {
            _accountDetailService = accountDetailService;
            _cashFlowService = cashFlowService;
        }

        // GET api/businessfinancebashboard/accountBalance?type=savings,current
        [HttpGet]
        [Route("accountBalance")]
        public async Task<IEnumerable<AccountBalance>> GetAccountBalance(string accountType)
        {
            return await _accountDetailService.GetAccountSummary();
        }

        // GET api/businessfinancebashboard/cashflow
        [HttpGet]
        [Route("cashflow")]
        public IEnumerable<CashFlow> GetCashFlow()
        {
            return _cashFlowService.GetCashFlowDetails();
        }

    }
}
