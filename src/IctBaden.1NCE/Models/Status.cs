using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Status indicating whether or not the threshold or the quota has been reached
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Numerical status on of 0, 1 or 2
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// Status description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Date on which the threshold of 80% of the quota was reached.
        /// </summary>
        [JsonProperty("threshold_reached_date")]
        public string ThresholdReachedDate { get; set; }
        /// <summary>
        /// Date on which the quota has Exceeded.
        /// </summary>
        [JsonProperty("quota_exceeded_date")]
        public string QuotaExceededDate { get; set; }
    }
}