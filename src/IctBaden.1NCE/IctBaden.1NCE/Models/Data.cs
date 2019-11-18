using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class Data
    {
        [JsonProperty("cost")]
        public string Cost { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("traffic_type")]
        public TrafficType TrafficType { get; set; }
        [JsonProperty("volume")]
        public string Volume { get; set; }
        [JsonProperty("volume_rx")]
        public string VolumeRx { get; set; }
        [JsonProperty("volume_tx")]
        public string VolumeTx { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("sms")]
        public Sms Sms { get; set; }
    }
}