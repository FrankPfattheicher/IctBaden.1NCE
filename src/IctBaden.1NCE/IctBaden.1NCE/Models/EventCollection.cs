using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class EventCollection
    {
        [JsonProperty("events")]
        public List<SimEvent> Events { get; set; }
        [JsonProperty("totalEvents")]
        public int TotalEvents { get; set; }
        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }
}