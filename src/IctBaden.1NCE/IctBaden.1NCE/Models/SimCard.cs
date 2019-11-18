using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden.Api1NCE.Models
{
    public class SimCard
    {
        /// <summary>
        /// ICCID
        /// example: 8988280666000000000
        /// </summary>
        [JsonProperty("iccid")]
        public string ICCID { get; set; }
        [JsonProperty("imsi")]
        public string IMSI { get; set; }
        [JsonProperty("msisdn")]
        public string MSISDN { get; set; }
        [JsonProperty("imei")]
        public string IMEI { get; set; }
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
        /// <summary>
        /// Activation date
        /// example: 2018-03-09T07:59:09.000+0000
        /// </summary>
        [JsonProperty("activation_date")]
        public string ActivationDate { get; set; }
        /// <summary>
        /// IP Address
        /// example: 100.100.100.18
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }
        /// <summary>
        /// Current Quota for this SIM in MB
        /// example: 500
        /// </summary>
        [JsonProperty("current_quota")]
        public long CurrentQuota { get; set; }
        /// <summary>
        /// Status indicating whether or not the threshold or the quota has been reached
        /// </summary>
        [JsonProperty("quota_status")]
        public Status QuotaStatus { get; set; }
        /// <summary>
        /// Label
        /// example: DX-137-B12
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}