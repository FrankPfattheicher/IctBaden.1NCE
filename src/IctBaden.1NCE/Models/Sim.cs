using System.Collections.Generic;
using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden.Api1NCE.Models
{
    public class Sim
    {
        /// <summary>
        /// ICCID
        /// example: 8988280666000000000
        /// </summary>
        [JsonProperty("iccid")]
        public string ICCID { get; set; }
        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }
}