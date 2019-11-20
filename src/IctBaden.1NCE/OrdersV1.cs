using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using IctBaden.Api1NCE.Models;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE
{
    public class OrdersV1 : IDisposable
    {
        private readonly string _apiUrl;
        private readonly WebClient _client;

        public OrdersV1(string apiUrl, string accessToken)
        {
            _apiUrl = apiUrl + "/management-api/v1/orders";
            _client = new WebClient();
            
            _client.Headers.Add(HttpRequestHeader.Accept, "application/json");
            _client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + accessToken);
        }

        public void Dispose()
        {
            _client?.Dispose();    
        }
        
        public List<Order> GetOrders()
        {
            try
            {
                var json = _client.DownloadString(_apiUrl);
                var orders = JsonConvert.DeserializeObject<List<Order>>(json);
                return orders;
            }
            catch (Exception ex)
            {
                Trace.TraceError("GetOrders: " + ex.Message);
                return null;
            }
        }
        
    }
}
