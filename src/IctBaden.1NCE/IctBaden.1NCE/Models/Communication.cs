using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class Communication
    {
        [JsonProperty("communicationDate")]
        public string CommunicationDate { get; set; }
        /// <summary>
        /// IN, OUT
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("originator")]
        public string Originator { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// PORTAL, PHONE_IN, PHONE_OUT, MAIL_IN, MAIL_OUT
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}