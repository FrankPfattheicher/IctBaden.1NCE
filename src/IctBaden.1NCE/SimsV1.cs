using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using IctBaden.Api1NCE.Models;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE
{
    public class SimsV1 : IDisposable
    {
        private readonly string _apiUrl;
        private readonly WebClient _client;

        public SimsV1(string apiUrl, string accessToken)
        {
            _apiUrl = apiUrl + "/management-api/v1/sims";
            _client = new WebClient();
            
            _client.Headers.Add(HttpRequestHeader.Accept, "application/json");
            _client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + accessToken);
        }

        public void Dispose()
        {
            _client?.Dispose();    
        }
        
        public List<SimCard> GetSimCards()
        {
            try
            {
                var json = _client.DownloadString(_apiUrl);
                var simCards = JsonConvert.DeserializeObject<List<SimCard>>(json);
                return simCards;
            }
            catch (Exception ex)
            {
                Trace.TraceError("GetSimCards: " + ex.Message);
                return null;
            }
        }

        public List<SimEvent> GetSimEvents(string iccid)
        {
            try
            {
                var json = _client.DownloadString(_apiUrl + $"/{iccid}/events");
                var eventCollection = JsonConvert.DeserializeObject<EventCollection>(json);
                return eventCollection.Events;
            }
            catch (Exception ex)
            {
                Trace.TraceError("GetSimEvents: " + ex.Message);
                return null;
            }
        }
        
    }
}