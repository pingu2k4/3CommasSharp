using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class SmartTradePosition
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public PositionType Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("units")]
        public DecimalValue Units { get; set; }

        /// <summary>
        /// Used for limit orders or price for smart sell
        /// Optional
        /// </summary>
        [JsonProperty("price")]
        public DecimalValue Price { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Required only if order type is conditional
        /// </summary>
        [JsonProperty("conditional")]
        public SmartTradePositionConditional Conditional { get; set; }
    }
}
