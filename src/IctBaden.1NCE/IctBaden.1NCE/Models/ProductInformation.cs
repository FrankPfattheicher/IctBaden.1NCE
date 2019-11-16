using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class ProductInformation
    {
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        /// <summary>
        /// Quantity of SIM with this product ordered
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}