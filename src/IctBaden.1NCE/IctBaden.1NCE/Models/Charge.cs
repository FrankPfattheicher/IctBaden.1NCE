using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// A product charge
    /// </summary>
    public class Charge
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("amount_net")]
        public float AmountNet { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}