using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Country of the operator
    /// </summary>
    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}