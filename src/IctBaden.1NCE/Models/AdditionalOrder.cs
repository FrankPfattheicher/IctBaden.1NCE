using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// General information about an order
    /// </summary>
    public class AdditionalOrder
    {
        [JsonProperty("products")]
        public List<OrderedProduct> Products { get; set; }
        [JsonProperty("delivery_address")]
        public Address DeliveryAddress { get; set; }
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }
        [JsonProperty("customer_reference")]
        public string CustomerReference { get; set; }
    }
}