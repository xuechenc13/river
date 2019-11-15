using System;
using System.Collections.Generic;
using CSharp.Models;
using CSharp.Storage;
namespace CSharp.Dao
{
    public class TradeDao : ITrade
    {
        public TradeDao()
        {
        }

        public string AddTrade(Trade trade)
        {
            throw new NotImplementedException();
        }

        public Trade DeleteTrade(string tradeId)
        {
            throw new NotImplementedException();
        }

        public List<Trade> DeleteTrade()
        {
            throw new NotImplementedException();
        }

        public List<Trade> QueryTrades()
        {
            throw new NotImplementedException();
        }

        public List<Trade> QueryTrades(string countryParty)
        {
            throw new NotImplementedException();
        }

        public Trade UpdateTrade(Trade trade)
        {
            throw new NotImplementedException();
        }
    }
}
