using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChargifyNET
{
    public class PricePoint
    {
        public int? Id { get; set; }
        [JsonProperty(PropertyName = "default")]
        public bool? @Default { get; set; }
        public string Name { get; set; }
        [JsonProperty(PropertyName = "pricing_scheme")]
        public string PricingScheme { get; set; }
        [JsonProperty(PropertyName = "component_id")]
        public int? ComponentId { get; set; }
        public string Handle { get; set; }
        [JsonProperty(PropertyName = "archived_at")]
        public DateTime? ArchivedAt { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
        public List<PricePointPrice> Prices { get; set; }
    }
}