using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class TrafficType
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}