using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// Optional information about the current location
    /// </summary>
    public class SubscriberInfo
    {
        /// <summary>
        /// Boolean flag indicating if the retrieved location is current
        /// </summary>
        [JsonProperty("current_location_retrieved")]
        public bool CurrentLocationRetrieved { get; set; }
        /// <summary>
        /// Age of the location information in minutes
        /// </summary>
        [JsonProperty("age_of_location")]
        public int AgeOfLocation { get; set; }
        [JsonProperty("cell_global_id")]
        public CellGlobalId CellGlobalId { get; set; }
    }
}