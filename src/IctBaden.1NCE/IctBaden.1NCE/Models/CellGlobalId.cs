using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden.Api1NCE.Models
{
    public class CellGlobalId
    {
        [JsonProperty("cid")]
        public int CID { get; set; }
        [JsonProperty("lac")]
        public int LAC { get; set; }
        [JsonProperty("mcc")]
        public string MCC { get; set; }
        [JsonProperty("mnc")]
        public string MNC { get; set; }
    }
}