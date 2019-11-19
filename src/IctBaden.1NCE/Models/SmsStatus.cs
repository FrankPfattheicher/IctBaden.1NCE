using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class SmsStatus
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// Status description
        /// example: DELIVERED
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}