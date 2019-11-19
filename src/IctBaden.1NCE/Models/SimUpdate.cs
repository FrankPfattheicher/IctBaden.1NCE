using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden.Api1NCE.Models
{
    public class SimUpdate
    {
        [JsonProperty("iccid")]
        public string ICCID { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        /// <summary>
        /// Indicates if SIM is locked to the current IMEI
        /// </summary>
        [JsonProperty("imei_lock")]
        public bool IMEILock { get; set; }
        /// <summary>
        /// Current Status
        /// Enabled, Disabled
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}