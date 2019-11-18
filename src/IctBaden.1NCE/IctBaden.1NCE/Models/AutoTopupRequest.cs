using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Contains a list of ICCIDs and a boolean flag for auto topup
    /// </summary>
    public class AutoTopupRequest
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        /// <summary>
        /// A list of ICCIDs
        /// </summary>
        [JsonProperty("iccids")]
        // ReSharper disable once InconsistentNaming
        public List<string> ICCIDs { get; set; }

    }
}