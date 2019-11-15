using System;
using System.Numerics;
namespace CSharp.Models
{
    public class Transaction
    {
        public Transaction()
        {
        }
        public string TransactionID { get; set; }
        public BigInteger Amount { get; set; }
        public DateTime Date { get; set; }
        public string TradeId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }

    }
}
