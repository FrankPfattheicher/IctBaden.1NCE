using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class SmsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Type description
        /// example: MT
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}