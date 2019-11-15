using System;
using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class CellGlobalId
    {
        [JsonProperty("cid")]
        public int Cid { get; set; }
        [JsonProperty("lac")]
        public int Lac { get; set; }
        [JsonProperty("mcc")]
        public string Mcc { get; set; }
        [JsonProperty("mnc")]
        public string Mnc { get; set; }
    }
}