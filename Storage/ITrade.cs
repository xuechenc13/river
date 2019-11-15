using System.Collections.Generic;

using CSharp.Models;

namespace CSharp.Storage
{
    public interface ITrade
    {

        string AddTrade(Trade trade);

        Trade DeleteTrade(string tradeId);

        Trade UpdateTrade(Trade trade);

        List<Trade> DeleteTrade();

        List<Trade> QueryTrades();

        List<Trade> QueryTrades(string countryParty);

    }
}
