using BFD.Models;
using BFD.Proxy;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BFD.Services
{
    public class AccountDetailService
    {
        private readonly AccountDetailProxy _accountDetailProxy;

        public AccountDetailService(AccountDetailProxy accountDetailProxy)
        {
            _accountDetailProxy = accountDetailProxy;
        }

        public async Task<IEnumerable<AccountBalance>> GetAccountSummary()
        {
            return await _accountDetailProxy.GetAccountSummary();
        }
    }
}
