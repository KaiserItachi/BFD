namespace BFD.Models
{
    public class AccountBalance
    {
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }
        public string Month { get; set; }
    }
}
