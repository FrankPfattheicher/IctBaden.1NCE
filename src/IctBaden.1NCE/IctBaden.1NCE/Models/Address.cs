using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// Address information
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Salutation - currently supported values are ‘1’ for ‘Mr’ and ‘2’ for ‘Ms’
        /// example: 2
        /// </summary>
        [JsonProperty("salutation")]
        public string Salutation { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Company name
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }
        /// <summary>
        /// House number
        /// </summary>
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }
        [JsonProperty("zip")]
        public string Zip { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// example: DE
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}