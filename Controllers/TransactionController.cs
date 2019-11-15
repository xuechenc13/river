using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using CSharp.Models;
using CSharp.Service;
using CSharp.Helper;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsactionController : Controller
    {
        TransactionService transactionService = new TransactionService();

        // GET api/transaction
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                HttpResponseMessage resp = new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(transactionService.QueryTransactions()), Encoding.UTF8, "application/json")
                };

                return resp;

            }
            catch
            {

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // GET api/transaction/5
        [HttpGet("{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                HttpResponseMessage resp = new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(transactionService.QueryTransactions(id)), Encoding.UTF8, "application/json")
                };

                return resp;

            }
            catch
            {

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // POST api/transaction
        [HttpPost]

        public HttpResponseMessage Post([FromBody]string value)
        {
            try
            {
                string transactionID = transactionService.CreateTransaction(JsonParser.GetTransaction(value));

                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(transactionID) };

            }
            catch
            {

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

     
        // DELETE api/transaction/5
        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                Transaction transaction = transactionService.DeleteTransaction(id);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json")

                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

        }

        [HttpDelete]
        public HttpResponseMessage Delete()
        {
            try
            {
                List<Transaction> transactions = transactionService.DeleteTransation();

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(transactions), Encoding.UTF8, "application/json")

                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

        }
    }
}
