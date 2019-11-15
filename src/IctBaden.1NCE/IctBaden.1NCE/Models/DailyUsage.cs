using System.Collections.Generic;
using Newtonsoft.Json;

namespace IctBaden._1NCE.Models
{
    public class DailyUsage
    {
        [JsonProperty("stats")]
        public List<Daily> Stats { get; set; }
    }
}