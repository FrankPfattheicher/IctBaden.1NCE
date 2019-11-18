using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// SMS to be send to SIM
    /// </summary>
    public class Sms
    {
        /// <summary>
        /// The source address
        /// example: 1234567890
        /// </summary>
        [JsonProperty("source_address")]
        public string SourceAddress { get; set; }
        /// <summary>
        /// The content of the SMS
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
        /// <summary>
        /// User Data Header encoded has hex-String (optional)
        /// </summary>
        [JsonProperty("udh")]
        public string UserDataHeader { get; set; }
        /// <summary>
        /// Data Coding Scheme (optional)
        /// example: 8
        /// </summary>
        [JsonProperty("dcs")]
        public int DataCodingScheme { get; set; }
        [JsonProperty("source_address_type")]
        public SourceAddressType SourceAddressType { get; set; }
        /// <summary>
        /// Expiry Date in ISO8601
        /// example: 2018-03-14T16:10:29.000+0000
        /// </summary>
        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }
    }
}