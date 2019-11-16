using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// Information about a Event. Besides the timestamp and the event_type all other values are optional and might not be included in the actual response
    /// </summary>
    public class SimEvent
    {
        /// <summary>
        /// Timestamp
        /// example: 2018-05-07T14:08:05.000+0000
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        /// <summary>
        /// A description of the event type
        /// example: Status of SIM changed from 'Issued' to 'Activated'
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; set; }
        [JsonProperty("iccid")]
        public string ICCID { get; set; }
        [JsonProperty("imei")]
        public string IMEI { get; set; }
        [JsonProperty("imsi")]
        public string IMSI { get; set; }
        /// <summary>
        /// Country
        /// example: Germany
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// Operator name
        /// example: T-Mobile
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }
        [JsonProperty("mcc")]
        public string MCC { get; set; }
        [JsonProperty("mnc")]
        public string MNC { get; set; }
        /// <summary>
        /// Boolean flag determining if this event is treated as an alert
        /// </summary>
        [JsonProperty("alert")]
        public bool Alert { get; set; }
        /// <summary>
        /// Textual representation of the severity of the event
        /// example: Info
        /// </summary>
        [JsonProperty("event_severity")]
        public string EventSeverity { get; set; }
    }
}