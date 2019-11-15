using System;
using System.Collections.Generic;
using CSharp.Models;
using CSharp.Dao;
namespace CSharp.Service
{
    public class TransactionService
    {
        private readonly TransactionDao transactionDao;
        public TransactionService()
        {
            transactionDao = new TransactionDao();
        }

        public List<Transaction> DeleteTransation()
        {
            return transactionDao.DeleteTransation();
        }

        public List<Transaction> QueryTransactions()
        {
            return transactionDao.QueryTransactions();
        }

        public List<Transaction> QueryTransactions(string tradeId)
        {
            return transactionDao.QueryTransactions(tradeId);
        }

        public string CreateTransaction(Transaction transaction)
        {
            return transactionDao.CreateTransaction(transaction);
        }

        public Transaction DeleteTransaction(string trandId)
        {
            return transactionDao.DeleteTransaction(trandId);
        }

    }
}
