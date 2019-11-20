using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using IctBaden.Api1NCE.Models;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE
{
    public class ProductsV1 : IDisposable
    {
        private readonly string _apiUrl;
        private readonly WebClient _client;

        public ProductsV1(string apiUrl, string accessToken)
        {
            _apiUrl = apiUrl + "/management-api/v1/products";
            _client = new WebClient();
            
            _client.Headers.Add(HttpRequestHeader.Accept, "application/json");
            _client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + accessToken);
        }

        public void Dispose()
        {
            _client?.Dispose();    
        }
        
        public List<Product> GetProducts()
        {
            try
            {
                var json = _client.DownloadString(_apiUrl);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                return products;
            }
            catch (Exception ex)
            {
                Trace.TraceError("GetProducts: " + ex.Message);
                return null;
            }
        }
        
    }
}
