using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class SourceAddressType
    {
        /// <summary>
        /// Numerical identifier for the type
        /// example: 145
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}