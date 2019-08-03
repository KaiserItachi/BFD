using BFD.Common;
using BFD.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BFD.Proxy
{
    public class AccountSummaryApiConfiguration
    {
        public string Url { get; set; }
        public string ClientId { get; set; }
        public string AccessToken { get; set; }
        public string Version { get; set; }

    }

    public class AccountDetailProxy
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptions<AccountSummaryApiConfiguration> _accountSummaryApiConfiguration;

        public AccountDetailProxy(IOptions<AccountSummaryApiConfiguration> accountSummaryApiConfiguration, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _accountSummaryApiConfiguration = accountSummaryApiConfiguration;
        }

        public async Task<IEnumerable<AccountBalance>> GetAccountSummary()
        {
            List<AccountBalance> accountBalances = new List<AccountBalance>();
            DBSAccountsSummary dBSAccountsSummary = new DBSAccountsSummary();

            var request = new HttpRequestMessage(HttpMethod.Get, _accountSummaryApiConfiguration.Value.Url);
            request.Headers.Add("clientId", _accountSummaryApiConfiguration.Value.ClientId);
            request.Headers.Add("accessToken", _accountSummaryApiConfiguration.Value.AccessToken);
            request.Headers.Add("version", _accountSummaryApiConfiguration.Value.Version);
            request.Headers.Add("User-Agent", "Business Finance Dashboard");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                dBSAccountsSummary = await response.Content.ReadAsAsync<DBSAccountsSummary>();
            }

            if (dBSAccountsSummary.SavingsAccounts != null)
            {
                foreach (DBSAccountSummary dbsAccountSummary in dBSAccountsSummary.SavingsAccounts)
                {
                    accountBalances.Add(new AccountBalance
                    {
                        AccountType = Constants.AccountType.Savings,
                        BankName = "DBS",
                        AccountNumber = dbsAccountSummary.AccountNumber,
                        Balance = dbsAccountSummary.Balances?.AvailableBalance?.Amount ?? 0
                    });
                }
            }

            if (dBSAccountsSummary.CurrentAccounts != null)
            {
                foreach (DBSAccountSummary dbsAccountSummary in dBSAccountsSummary.CurrentAccounts)
                {
                    accountBalances.Add(new AccountBalance
                    {
                        AccountType = Constants.AccountType.Current,
                        BankName = "DBS",
                        AccountNumber = dbsAccountSummary.AccountNumber,
                        Balance = dbsAccountSummary.Balances?.AvailableBalance?.Amount ?? 0
                    }                    );
                }
            }
            return accountBalances;
        }
    }

}
