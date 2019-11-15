using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// General information about an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order No. - the unique numerical identifier for a order
        /// example: 2000000001
        /// </summary>
        [JsonProperty("order_number")]
        public long OrderNumber { get; set; }
        /// <summary>
        /// The order type indicates whether this is a first order, additional order or a topup
        /// example: FIRST_ORDER
        /// FIRST_ORDER, ADDITIONAL_ORDER, TOPUP, BULK_TOPUP
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
        [JsonProperty("order_date")]
        public string OrderDate { get; set; }
        /// <summary>
        /// Status of the Order
        /// example: COMPLETED
        /// </summary>
        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }
        /// <summary>
        /// Invoice No. - unique alphanumerical identifier for the corresponding invoice
        /// example: 20000002
        /// </summary>
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// The gross value which this order amounts to, as printed on the invoice
        /// example: 19.99
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }
        /// <summary>
        /// ISO 4217 currency code used for the invoice amount
        /// example: EUR
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
        /// <summary>
        /// SIMs included or affected by this Order
        /// </summary>
        [JsonProperty("sims")]
        public List<Sim> Sims { get; set; }
        /// <summary>
        /// IDs and quantity of ordered products
        /// </summary>
        [JsonProperty("products")]
        public List<ProductInformation> Products { get; set; }
    }
}