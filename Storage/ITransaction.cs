using System;
using System.Collections.Generic;

using CSharp.Models;

namespace CSharp.Storage
{
    public interface ITransaction
    {
        string CreateTransaction(Transaction transaction);

        Transaction DeleteTransaction(string transactionId);

        List<Transaction> DeleteTransation();

        List<Transaction> QueryTransactions();

        List<Transaction> QueryTransactions(string tradeId);
    }

}
