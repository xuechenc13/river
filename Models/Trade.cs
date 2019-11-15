using System;
using System.Data;
namespace CSharp.Models
{
    public class Trade 
    {
        public Trade()
        {

        }
        public string TradeID { get; set; }

        public string TradeName { get; set; }
        public string CounterpartyId { get; set; }
        public string Notional { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }

    }
}
