namespace BFD.Models
{
    public class CashFlow
    {
        public int CustomerId { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal Receivable { get; set; }
        public decimal Payable { get; set; }
    }
}
