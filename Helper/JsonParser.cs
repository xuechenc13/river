using System;
using Newtonsoft.Json.Linq;
using CSharp.Models;
using System.Numerics;
namespace CSharp.Helper
{
    public class JsonParser
    {
      
        public static Trade GetTrade(string parserText) {

            //TODO to get all of the trade information
            JObject jo = JObject.Parse(parserText);
            Trade trade = new Trade();
            trade.TradeID = (null == jo["TradeID"]) ? string.Empty : jo["TradeID"].ToString();
            trade.TradeName = jo["TradeName"].ToString();
           
            return trade;
        }

        public static Transaction GetTransaction(string parserText)
        {
            //TODO to get all of the transaction information
            JObject jo = JObject.Parse(parserText);
            Transaction trade = new Transaction();
            trade.TransactionID = (null == jo["TransactionID"]) ? string.Empty : jo["TransactionID"].ToString();
            trade.Amount = BigInteger.Parse(jo["Amount"].ToString());

            return trade;
        }
    }
}
