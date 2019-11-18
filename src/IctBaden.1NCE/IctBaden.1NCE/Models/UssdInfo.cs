using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Optional ussd information, only set if the parameter ‘ussd’ is set to true.
    /// </summary>
    public class UssdInfo
    {
        /// <summary>
        /// Boolean flag indicating the success
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        /// Optional information if some error occurred
        /// example: Request Timeout Error
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}