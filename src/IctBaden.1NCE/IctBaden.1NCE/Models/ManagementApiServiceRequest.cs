using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class ManagementApiServiceRequest
    {
        [JsonProperty("replyToMail")]
        public string ReplyToMail { get; set; }
        [JsonProperty("senderName")]
        public string SenderName { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}