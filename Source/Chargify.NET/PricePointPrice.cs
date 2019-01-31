using Newtonsoft.Json;

namespace ChargifyNET
{
    public class PricePointPrice
    {
        public int? Id { get; set; }
        [JsonProperty(PropertyName = "component_id")]
        public int? ComponentId { get; set; }
        [JsonProperty(PropertyName = "starting_quantity")]
        public int? StartingQuantity { get; set; }
        [JsonProperty(PropertyName = "ending_quantity")]           
        public int? EndingQuantity { get; set; }
        [JsonProperty(PropertyName = "unit_price")]
        public decimal? UnitPrice { get; set; }
    }
}