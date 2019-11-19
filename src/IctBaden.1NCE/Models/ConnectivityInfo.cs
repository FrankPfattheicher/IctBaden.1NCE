using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Contains connectivity and location information
    /// </summary>
    public class ConnectivityInfo
    {
        [JsonProperty("ussd_info")]
        public UssdInfo UssdInfo { get; set; }
        [JsonProperty("subscriber_info")]
        public SubscriberInfo SubscriberInfo { get; set; }
        /// <summary>
        /// Time in UTC the request was received
        /// example: 2018-11-07T17:21:46.121+0000
        /// </summary>
        [JsonProperty("request_timestamp")]
        public string RequestTimestamp { get; set; }
        /// <summary>
        ///Time in UTC the response was sent
        /// example: 2018-11-07T17:21:46.263+0000 
        /// </summary>
        [JsonProperty("reply_timestamp")]
        public string ReplyTimestamp { get; set; }
    }
}