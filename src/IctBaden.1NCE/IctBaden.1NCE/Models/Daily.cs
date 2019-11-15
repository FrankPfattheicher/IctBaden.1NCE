using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class Daily
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("sms")]
        public Sms Sms { get; set; }
    }
}