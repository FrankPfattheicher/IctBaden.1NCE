using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Information about a product
    /// </summary>
    public class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// Product name 
        /// </summary>
        [JsonProperty("product")]
        public string Name { get; set; }
        [JsonProperty("material")]
        public string Material { get; set; }
        [JsonProperty("package_size")]
        public long PackageSize { get; set; }
        [JsonProperty("min_contract_duration")]
        public long MinContractDuration { get; set; }
        [JsonProperty("one_time_charges")]
        public Charge OneTimeCharges { get; set; }
        [JsonProperty("recurring_charges")]
        public Charge RecurringCharges { get; set; }
     }
}