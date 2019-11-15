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
    public class TradeController : Controller
    {
        TradeService tradeService = new TradeService();

        // GET api/trade
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                HttpResponseMessage resp = new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(tradeService.QueryTrades()), Encoding.UTF8, "application/json")
                };

                return resp;

            }
            catch
            {

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // GET api/trade/5
        [HttpGet("{id}")]
        public HttpResponseMessage Get(string countryParty)
        {
            try
            {
                HttpResponseMessage resp = new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(tradeService.QueryTrades(countryParty)), Encoding.UTF8, "application/json")
                };

                return resp;

            }
            catch {

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // POST api/trade
        [HttpPost]
        
        public HttpResponseMessage Post([FromBody]string value)
        {
            try { 
                string tradeID = tradeService.AddTrade(JsonParser.GetTrade(value));

                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(tradeID) };

            } catch{ 

                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // PUT api/trade/
        [HttpPut("{id}")]
        public HttpResponseMessage Put([FromBody]string value)
        {
            try
            {

                Trade trade = tradeService.UpdateTrade(JsonParser.GetTrade(value));

                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(trade.TradeID) };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/trade/5
        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                Trade trade = tradeService.DeleteTrade(id);

                return new HttpResponseMessage(HttpStatusCode.OK) {
                    Content = new StringContent(JsonConvert.SerializeObject(trade), Encoding.UTF8, "application/json")

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
                List<Trade> trades = tradeService.DeleteTrade();

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(trades), Encoding.UTF8, "application/json")

                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

        }
    }
}
