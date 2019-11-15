using System;
using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    /// <summary>
    /// What you want and how much of it
    /// </summary>
    public class OrderedProduct
    {
        [JsonProperty("productId")]
        public long ProductId { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}