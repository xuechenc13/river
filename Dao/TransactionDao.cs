using System;
using System.Collections.Generic;
using CSharp.Models;
using CSharp.Storage;
namespace CSharp.Dao
{
    public class TransactionDao : ITransaction
    {
        public TransactionDao()
        {
        }

        public string CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction DeleteTransaction(string transactionId)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> DeleteTransation()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> QueryTransactions()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> QueryTransactions(string tradeId)
        {
            throw new NotImplementedException();
        }
    }
}
