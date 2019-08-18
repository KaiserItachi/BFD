using BFD.Models;
using System.Collections.Generic;

namespace BFD.Proxy
{
    public class CashFlowProxy
    {
        public List<CashFlow> GetCashFlowDetails()
        {
            return new List<CashFlow> {
                new CashFlow { CustomerId = 1, Month = "Aug", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { CustomerId = 1, Month = "Sep", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { CustomerId = 1, Month = "Oct", Year = "2019", Receivable = 80000, Payable = 90000 },
                new CashFlow { CustomerId = 1, Month = "Nov", Year = "2019", Receivable = 120000, Payable = 80000 },
                new CashFlow { CustomerId = 1, Month = "Dec", Year = "2019", Receivable = 100000, Payable = 85000 },
                new CashFlow { CustomerId = 1, Month = "Jan", Year = "2020", Receivable = 80000, Payable = 90000 },
                new CashFlow { CustomerId = 1, Month = "Feb", Year = "2020", Receivable = 110000, Payable = 140000 },
                new CashFlow { CustomerId = 1, Month = "Mar", Year = "2020", Receivable = 100000, Payable = 120000 },
                new CashFlow { CustomerId = 1, Month = "Apr", Year = "2020", Receivable = 80000, Payable = 100000 },
                new CashFlow { CustomerId = 1, Month = "May", Year = "2020", Receivable = 85000, Payable = 80000 },
                new CashFlow { CustomerId = 1, Month = "Jun", Year = "2020", Receivable = 90000, Payable = 110000 },
                new CashFlow { CustomerId = 1, Month = "Jul", Year = "2020", Receivable = 100000, Payable = 120000 },

                new CashFlow { CustomerId = 2, Month = "Aug", Year = "2019", Receivable = 55000, Payable = 45000 },
                new CashFlow { CustomerId = 2, Month = "Sep", Year = "2019", Receivable = 70000, Payable = 350000 },
                new CashFlow { CustomerId = 2, Month = "Oct", Year = "2019", Receivable = 60000, Payable = 65000 },
                new CashFlow { CustomerId = 2, Month = "Nov", Year = "2019", Receivable = 90000, Payable = 80000 },
                new CashFlow { CustomerId = 2, Month = "Dec", Year = "2019", Receivable = 120000, Payable = 105000 },
                new CashFlow { CustomerId = 2, Month = "Jan", Year = "2020", Receivable = 40000, Payable = 70000 },
                new CashFlow { CustomerId = 2, Month = "Feb", Year = "2020", Receivable = 80000, Payable = 90000 },
                new CashFlow { CustomerId = 2, Month = "Mar", Year = "2020", Receivable = 110000, Payable = 95000 },
                new CashFlow { CustomerId = 2, Month = "Apr", Year = "2020", Receivable = 55000, Payable = 65000 },
                new CashFlow { CustomerId = 2, Month = "May", Year = "2020", Receivable = 45000, Payable = 50000 },
                new CashFlow { CustomerId = 2, Month = "Jun", Year = "2020", Receivable = 70000, Payable = 60000 },
                new CashFlow { CustomerId = 2, Month = "Jul", Year = "2020", Receivable = 115000, Payable = 130000 }
            };
        }
    }
}
