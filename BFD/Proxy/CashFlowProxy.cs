using BFD.Models;
using System.Collections.Generic;

namespace BFD.Proxy
{
    public class CashFlowProxy
    {
        public List<CashFlow> GetCashFlowDetails()
        {
            return new List<CashFlow> {
                new CashFlow { Month = "Aug", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { Month = "Sep", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { Month = "Oct", Year = "2019", Receivable = 80000, Payable = 90000 },
                new CashFlow { Month = "Nov", Year = "2019", Receivable = 120000, Payable = 80000 },
                new CashFlow { Month = "Dec", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { Month = "Jan", Year = "2020", Receivable = 80000, Payable = 90000 },
                new CashFlow { Month = "Feb", Year = "2020", Receivable = 110000, Payable = 140000 },
                new CashFlow { Month = "Mar", Year = "2020", Receivable = 100000, Payable = 120000 },
                new CashFlow { Month = "Apr", Year = "2020", Receivable = 80000, Payable = 100000 },
                new CashFlow { Month = "May", Year = "2020", Receivable = 85000, Payable = 80000 },
                new CashFlow { Month = "Jun", Year = "2020", Receivable = 90000, Payable = 110000 },
                new CashFlow { Month = "Jul", Year = "2020", Receivable = 100000, Payable = 120000 },
            };
        }
    }
}
