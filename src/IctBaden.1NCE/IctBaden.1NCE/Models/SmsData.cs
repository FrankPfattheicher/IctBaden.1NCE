using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace IctBaden._1NCE.Models
{
    public class SmsData
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// The date and time on which this SMS was submitted
        /// </summary>
        [JsonProperty("submit_date")]
        public string SubmitDate { get; set; }
        /// <summary>
        /// The date and time on which this SMS was delivered
        /// </summary>
        [JsonProperty("delivery_date")]
        public string DeliveryDate { get; set; }
        /// <summary>
        /// The date and time on which this SMS will expire
        /// </summary>
        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }
        /// <summary>
        /// The final date and time
        /// </summary>
        [JsonProperty("final_date")]
        public string FinalDate { get; set; }
        /// <summary>
        /// The date and time on which the delivery was retried
        /// </summary>
        [JsonProperty("retry_date")]
        public string RetryDate { get; set; }
        /// <summary>
        /// The date and time on which the last delivery was attempted
        /// </summary>
        [JsonProperty("last_delivery_attempt")]
        public string LastDeliveryAttempt { get; set; }
        [JsonProperty("retry_count")]
        public string RetryCount { get; set; }
        /// <summary>
        /// The source address
        /// example: 1234567890
        /// </summary>
        [JsonProperty("source_address")]
        public string SourceAddress { get; set; }
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
        [JsonProperty("msc")]
        public string MSC { get; set; }
        /// <summary>
        /// Data Coding Scheme (optional)
        /// example: 8
        /// </summary>
        [JsonProperty("dcs")]
        public int DataCodingScheme { get; set; }
        /// <summary>
        /// User Data Header encoded has hex-String (optional)
        /// </summary>
        [JsonProperty("udh")]
        public string UserDataHeader { get; set; }
        /// <summary>
        /// The content of the SMS
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("status")]
        public SmsStatus Status { get; set; }
        [JsonProperty("sms_type")]
        public SmsType SmsType { get; set; }
        [JsonProperty("source_address_type")]
        public SourceAddressType SourceAddressType { get; set; }
    }
}