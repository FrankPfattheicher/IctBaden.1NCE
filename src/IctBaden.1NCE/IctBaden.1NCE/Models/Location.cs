using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// Location information.
    /// </summary>
    public class Location
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("rat_type_id")]
        public string RatTypeId { get; set; }
    }
}