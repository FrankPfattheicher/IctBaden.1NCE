using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class Link
    {
        /// <summary>
        /// example: self
        /// </summary>
        [JsonProperty("rel")]
        public string Rel { get; set; }
        /// <summary>
        /// example: https://api.1nce.com/api/v1/sims/9999999999000000001
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}