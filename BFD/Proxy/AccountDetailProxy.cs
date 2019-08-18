using System.Collections.Generic;
using System.Net.Http;
using BFD.Models;
using Microsoft.Extensions.Options;

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
        public List<AccountBalance> GetAccountBalances()
        {
            return new List<AccountBalance>
            {
                new AccountBalance { CustomerId = 1, AccountNumber= "243158", BankName= "DBS", Month = "Jan", Balance= 2000},
                new AccountBalance { CustomerId = 1, AccountNumber= "123157", BankName= "CBA", Month = "Jan", Balance= 3300},
                new AccountBalance { CustomerId = 1, AccountNumber= "756213", BankName= "ING", Month = "Jan", Balance= 5535},
                new AccountBalance { CustomerId = 1, AccountNumber= "354134", BankName= "HDFC", Month = "Jan", Balance= 1235},
                new AccountBalance { CustomerId = 1, AccountNumber= "243158", BankName= "DBS", Month = "Feb", Balance= 1800},
                new AccountBalance { CustomerId = 1, AccountNumber= "123157", BankName= "CBA", Month = "Feb", Balance= 3500},
                new AccountBalance { CustomerId = 1, AccountNumber= "756213", BankName= "ING", Month = "Feb", Balance= 5500},
                new AccountBalance { CustomerId = 1, AccountNumber= "354134", BankName= "HDFC", Month = "Feb", Balance= 1200},
                new AccountBalance { CustomerId = 1, AccountNumber= "243158", BankName= "DBS", Month = "Mar", Balance= 2200},
                new AccountBalance { CustomerId = 1, AccountNumber= "123157", BankName= "CBA", Month = "Mar", Balance= 2700},
                new AccountBalance { CustomerId = 1, AccountNumber= "756213", BankName= "ING", Month = "Mar", Balance= 5000},
                new AccountBalance { CustomerId = 1, AccountNumber= "354134", BankName= "HDFC", Month = "Mar", Balance= 1250},
                new AccountBalance { CustomerId = 1, AccountNumber= "243158", BankName= "DBS", Month = "Apr", Balance= 2345},
                new AccountBalance { CustomerId = 1, AccountNumber= "123157", BankName= "CBA", Month = "Apr", Balance= 2500},
                new AccountBalance { CustomerId = 1, AccountNumber= "756213", BankName= "ING", Month = "Apr", Balance= 4815},
                new AccountBalance { CustomerId = 1, AccountNumber= "354134", BankName= "HDFC", Month = "Apr", Balance= 1800},

                new AccountBalance { CustomerId = 2, AccountNumber= "457841", BankName= "DBS", Month = "Jan", Balance= 500},
                new AccountBalance { CustomerId = 2, AccountNumber= "321121", BankName= "CBA", Month = "Jan", Balance= 1200},
                new AccountBalance { CustomerId = 2, AccountNumber= "535434", BankName= "ING", Month = "Jan", Balance= 8400},
                new AccountBalance { CustomerId = 2, AccountNumber= "897653", BankName= "HDFC", Month = "Jan", Balance= 1800},
                new AccountBalance { CustomerId = 2, AccountNumber= "457841", BankName= "DBS", Month = "Feb", Balance= 300},
                new AccountBalance { CustomerId = 2, AccountNumber= "321121", BankName= "CBA", Month = "Feb", Balance= 900},
                new AccountBalance { CustomerId = 2, AccountNumber= "535434", BankName= "ING", Month = "Feb", Balance= 9800},
                new AccountBalance { CustomerId = 2, AccountNumber= "897653", BankName= "HDFC", Month = "Feb", Balance= 2200},
                new AccountBalance { CustomerId = 2, AccountNumber= "457841", BankName= "DBS", Month = "Mar", Balance= 800},
                new AccountBalance { CustomerId = 2, AccountNumber= "321121", BankName= "CBA", Month = "Mar", Balance= 1700},
                new AccountBalance { CustomerId = 2, AccountNumber= "535434", BankName= "ING", Month = "Mar", Balance= 10500},
                new AccountBalance { CustomerId = 2, AccountNumber= "897653", BankName= "HDFC", Month = "Mar", Balance= 700},
                new AccountBalance { CustomerId = 2, AccountNumber= "457841", BankName= "DBS", Month = "Apr", Balance= 1045},
                new AccountBalance { CustomerId = 2, AccountNumber= "321121", BankName= "CBA", Month = "Apr", Balance= 7500},
                new AccountBalance { CustomerId = 2, AccountNumber= "535434", BankName= "ING", Month = "Apr", Balance= 2815},
                new AccountBalance { CustomerId = 2, AccountNumber= "897653", BankName= "HDFC", Month = "Apr", Balance= 2800}
            };
        }
    }

}
