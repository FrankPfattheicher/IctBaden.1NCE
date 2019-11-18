using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    public class Quota
    {
        /// <summary>
        /// Currently available Volume, either SMS or data in MB
        /// </summary>
        [JsonProperty("volume")]
        public long Volume { get; set; }
        /// <summary>
        /// The total data volume or SMS this SIM has available over its lifetime
        /// </summary>
        [JsonProperty("total_volume")]
        public long TotalVolume { get; set; }
        /// <summary>
        /// Date this quota will expire
        /// </summary>
        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }
        /// <summary>
        /// The optional throughput in bit/s (only for data quotas)
        /// </summary>
        [JsonProperty("peak_throughput")]
        public int PeakThroughput { get; set; }
        /// <summary>
        /// Amount of SMS or data volume which was last purchased for this SIM
        /// </summary>
        [JsonProperty("last_volume_added")]
        public long LastVolumeAdded { get; set; }
        /// <summary>
        /// Last date and time on which this quota was changed, e.g. by purchasing a TopUp
        /// example: 2018-10-01 11:59:44
        /// </summary>
        [JsonProperty("last_status_change_date")]
        public string LastStatusChangeDate { get; set; }
        /// <summary>
        /// Threshold in percentage for which a volume notification will be send
        /// example: 20
        /// </summary>
        [JsonProperty("threshold_percentage")]
        public int ThresholdPercentage { get; set; }
    }
}