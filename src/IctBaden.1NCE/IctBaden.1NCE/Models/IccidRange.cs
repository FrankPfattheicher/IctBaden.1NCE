using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class IccidRange
    {
        /// <summary>
        /// The first ICCID of the range
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }
        /// <summary>
        /// The last ICCID of the range
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }
    }
}