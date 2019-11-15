using System;
using System.Collections.Generic;
using CSharp.Dao;
using CSharp.Models;
namespace CSharp.Service
{
    public class TradeService
    {
        private readonly TradeDao tradeDao;
        public TradeService()
        {
            tradeDao = new TradeDao();
        }

        public string AddTrade(Trade trade) {
            return tradeDao.AddTrade(trade);
        }

        public Trade UpdateTrade(Trade trade) {
            return tradeDao.UpdateTrade(trade);
        }

        public Trade DeleteTrade(string tradeId) {

            return tradeDao.DeleteTrade(tradeId);
        }
        public List<Trade> DeleteTrade()
        {
            return tradeDao.DeleteTrade();
        }

        public List<Trade> QueryTrades() {
            return tradeDao.QueryTrades();
        
        }
        public List<Trade> QueryTrades(string countryParty) {           
            return tradeDao.QueryTrades(countryParty);
        }

    }
}
