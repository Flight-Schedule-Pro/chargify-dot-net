using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChargifyNET
{
    public class PricePointsContainer
    {
        [JsonProperty(PropertyName = "price_points")]
        public List<PricePoint> PricePoints { get; set; }
    }
}
