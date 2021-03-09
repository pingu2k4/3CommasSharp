using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class PriceTrigger
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Optional. Defaults to ask for long trades or bid for short trades
        /// </summary>
        [JsonProperty("type")]
        public LastPriceType? Type { get; set; }
    }
}
