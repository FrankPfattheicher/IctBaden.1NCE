using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Contains connectivity status
    /// </summary>
    public class Connectivity
    {
        /// <summary>
        /// The status of the connectivity
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("pdp_context")]
        public PdpContext PdpContext { get; set; }
        /// <summary>
        /// List of services
        /// </summary>
        [JsonProperty("services")]
        public List<string> Services { get; set; }
    }
}